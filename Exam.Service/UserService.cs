using Exam.Data.Infrastructure;
using Exam.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Service
{
    public class UserService : Service<UserAccount>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);

        public UserService()
           : base(ut)
        {
        }

        public ICollection<UserAccount> GetGaragisteExpert(int idGarage, int idExpert)
        {
            return ut.getRepository<UserAccount>().GetMany(x => x.UserId == idGarage || x.UserId == idExpert).ToList();
        }


    }
}
