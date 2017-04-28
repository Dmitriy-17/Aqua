using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Entities.Contract;

namespace AdoNet
{
    public class Context : DbContext
    {
        public Context() : base ("tesDB")
        { }
        public virtual DbSet<Contract> Contracts { get; set; }
    }
}
