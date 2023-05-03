using Core.Entities;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class UserDto : IDto
    {
        public int UserId { get; set; }
        public Rank Rank { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string? Image { get; set; }
        public string? About { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
