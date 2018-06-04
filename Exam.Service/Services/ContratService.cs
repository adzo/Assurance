using Exam.Data.Infrastructure;
using Exam.Domain.Entities;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Service.Services
{
    public class ContratService : Service<Contrat>
    {
        private static IDatabaseFactory dbf = new DatabaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(dbf);
        public ContratService() : base(ut)
        {
            
        }
        public Contrat getContratById(int idContrat)
        {
            Contrat result = ut.getRepository<Contrat>().GetById(idContrat);
            return result;
        }
    }
}
