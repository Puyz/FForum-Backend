using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PostDto : IDto
    {
        public int PostId { get; set; }
        public PostUserDto User { get; set; }
        public Category Category { get; set; }
        public SubCategory? SubCategory { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
