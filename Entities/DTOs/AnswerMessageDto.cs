using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class AnswerMessageDto : IDto
    {
        public int Id { get; set; }
        public PostUserDto User { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
