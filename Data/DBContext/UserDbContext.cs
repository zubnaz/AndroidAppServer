using Data.Configs;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data.DBContext
{
    public class UserDbContext:IdentityDbContext
    {
        private readonly IOptions<ConnectionProperty> connectionProperty;
        public UserDbContext(IOptions<ConnectionProperty> connectionProperty)
        {
            this.connectionProperty = connectionProperty;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionProperty.Value.LocalDb);
        }
    }
}
