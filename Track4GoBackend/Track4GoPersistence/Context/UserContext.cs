using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Track4GoDomain.Entities;

namespace Track4GoPersistence.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<UserEntity> Tbl_User {get; set;}
    }
}
