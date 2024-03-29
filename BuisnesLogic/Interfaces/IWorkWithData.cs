using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnesLogic.Interfaces
{
    public interface IWorkWithData
    {
        void Register(IdentityUser user);
    }
}
