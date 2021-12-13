using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using FluentFTP;
namespace OQC.Business
{
    public static class Utils
    {
        public static void UploadFile(string host, string username, string password, string localPath, string remotePath)
        {
            
            using (var ftp = new FtpClient(host, username, password))
            {
                ftp.Connect();
                ftp.UploadFile(localPath, remotePath, FtpRemoteExists.Overwrite, true, FtpVerify.Retry);
            }
        }
        public static string DownloadFile(string host, string username, string password, string localPath, string remotePath)
        {
            using (var ftp = new FtpClient(host, username, password))
            {
                ftp.Connect();
                ftp.DownloadFile(localPath, remotePath, FtpLocalExists.Overwrite, FtpVerify.Retry);
                return localPath;
            }
        }

    }

    public static class Encrypt
    {

        public static string MD5Hash(this string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits  
                //for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

    }
}
