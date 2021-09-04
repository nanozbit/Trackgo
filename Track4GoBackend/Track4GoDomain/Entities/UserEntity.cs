using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Track4GoDomain.Entities
{
    public class UserEntity
    {
        [Key]
        public Guid Id_User { get; set; }
        public string Name_User { get; set; }
        public string  IdentityDocument_User { get; set; }
        public string  Telephone_User { get; set; }
        public string  Mail_User { get; set; }

    }
}
