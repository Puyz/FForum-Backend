using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.DTOs;
using Repositories.Abstracts;
using Services.Abstracts;


namespace Services.Concretes
{
    public class MessageManager : IMessageService
    {
        private IMessageRepository messageRepository;
        public MessageManager(IMessageRepository messageRepository) { 
            this.messageRepository = messageRepository;
        }
        public IDataResult<List<MessageDto>> GetMessagesByPostId(int postId)
        {
            return new SuccessDataResult<List<MessageDto>>(messageRepository.GetMessagesByPostId(postId));
        }
    }
}
