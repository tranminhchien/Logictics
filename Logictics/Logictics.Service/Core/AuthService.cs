using Common.Utils;
using Logictics.DAL.Repository;
using Logictics.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logictics.Service.Core
{
    public interface IAuthService
    {
        UserViewModel GetLoginUser(string email, string password);
    }
    public class AuthService : IAuthService
    {
        private readonly IUserRepo _userRepo;
        private readonly IDatetimeUtil _datetimeUtil;

        public AuthService(IUserRepo userRepo, IDatetimeUtil datetimeUtil)
        {
            _userRepo = userRepo;
            _datetimeUtil = datetimeUtil;
        }

        public UserViewModel GetLoginUser(string email, string password)
        {
            var entry = _userRepo.GetUserByUserName(email, password).FirstOrDefault();
            if (entry == null)
            {
                return null;
            }

            //update time LastLogin
            //entry.LastLogin = _datetimeUtil.ConvertUniversalTimeToTimestamp(DateTime.UtcNow);
            _userRepo.Update(entry);

            return new UserViewModel
            {
                Id = entry.Id,
                Email = entry.UserName,
                Password = entry.PassWord,
                Role = entry.Role
            };
        }
    }
}
