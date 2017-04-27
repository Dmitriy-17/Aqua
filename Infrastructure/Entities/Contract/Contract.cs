using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Contracts;

namespace Infrastructure.Entities.Contract
{
    public class Contract : IEntity
    {
        public int Id { get; set; }
    }
}
