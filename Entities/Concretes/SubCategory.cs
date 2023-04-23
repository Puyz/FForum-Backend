using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class SubCategory : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set;}
        public string Name { get; set; }
    }
}
