using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class NavbarCategoryDto  : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubCategory> SubCategory { get; set; }

    }
}
