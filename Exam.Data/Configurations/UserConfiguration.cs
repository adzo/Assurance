using Exam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Data.Configurations
{
    public class UserConfiguration : EntityTypeConfiguration<UserAccount>
    {
        public UserConfiguration()
        {

            
        }
    }
}
