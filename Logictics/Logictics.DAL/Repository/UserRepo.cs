using Logictics.DAL.EFContext;
using Logictics.DAL.Infrastructure;
using Logictics.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logictics.DAL.Repository
{
    public interface IUserRepo : IRepo<UserAdmin>
    {
        IQueryable<UserAdmin> GetUserByUserName(string email, string password);

        //IEnumerable<UserAdmin> GetAllInclude();
        //UserAdmin GetInclude(int id);

    }
    public class UserRepo : Repo<UserAdmin>, IUserRepo
    {

      

        public UserRepo(DbContextOptions<LogicticsDbContext> options) : base(options)
        {

        }

        public IQueryable<UserAdmin> GetUserByUserName(string email, string password)
        {
            return Table.Where(x => x.UserName == email && x.PassWord == password);
        }
      
    }
}
