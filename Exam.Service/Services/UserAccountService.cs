using Exam.Data.Infrastructure;
using Exam.Domain.Entities;
using Exam.Service.Interfaces;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Service.Services
{
    public class UserAccountService : Service<UserAccount>, IUserAccountService
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public UserAccountService() : base(ut)
        {

        }
    }
}
