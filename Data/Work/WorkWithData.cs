using BuisnesLogic.Interfaces;
using Data.DBContext;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Work
{
    public class WorkWithData : IWorkWithData
    {
        private readonly UserDbContext _userDbContext;
        public WorkWithData(UserDbContext _userDbContext)
        {
            this._userDbContext = _userDbContext;
        }
        public void Register(IdentityUser user)
        {
           _userDbContext.Users.Add(user);
        }
    }
}
