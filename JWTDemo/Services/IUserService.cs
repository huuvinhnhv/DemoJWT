using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTDemo.Services
{
    public interface IUserService
    {
        string Login(string userName, string password);
    }
}
