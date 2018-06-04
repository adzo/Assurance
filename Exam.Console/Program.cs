using Exam.Data;
using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<Garantie> garanties = new List<Garantie>
            {
                new Garantie{ GarantieName = "Responsabilité Civile"},
                new Garantie{ GarantieName = "Défenses et recours"},
                new Garantie{ GarantieName = "Vol"},
                new Garantie{ GarantieName = "Incendie"},
                new Garantie{ GarantieName = "Personnes transportées"},
                new Garantie{ GarantieName = "Dommage aux véhicules"}
            };
            UserDbContext u = new UserDbContext();
            u.Garanties.AddRange(garanties);
            u.SaveChanges();
        }
    }
}
