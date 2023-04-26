using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public int RankId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string? Image { get; set; }
        public string? About { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
