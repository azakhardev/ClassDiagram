using ClassDiagram.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Class> Class { get; set; }

        public DbSet<Tables.Attribute> Attribute { get; set; }

        public DbSet<Operation> Operation { get; set; }

        public DbSet<OperationAttribute> OperationAttribue { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=4b2_zakharchenkoartem_db2;user=zakharchenkoarte;password=123456;SslMode=none");
        }
    }
}
