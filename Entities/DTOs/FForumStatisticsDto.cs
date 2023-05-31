using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class FForumStatisticsDto : IDto
    {
        public int PostCount { get; set; }
        public int MessageCount { get; set; }
        public int UserCount { get; set; }
    }
}
