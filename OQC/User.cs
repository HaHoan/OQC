//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OQC
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Department_id { get; set; }
        public Nullable<int> Position_id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string MailCC { get; set; }
        public string Customer { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
