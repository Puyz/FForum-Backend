using Core.Repositories.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;
using Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Concretes.EntityFramework
{
    public class EfMessageRepository : EfEntityRepositoryBase<Message, FForumContext>, IMessageRepository
    {
        public List<MessageDto> GetMessagesByPostId(int postId)
        {
            using (var context = new FForumContext())
            {
                var result = (from message in context.Messages
                              where message.PostId == postId
                              join user in context.Users! on message.UserId equals user.Id
                              join rank in context.Ranks! on user.RankId equals rank.Id
                              join answerMessage in context.Messages! on message.AnswerMessageId equals answerMessage.Id
                              into answerMessages
                              from answerMessage in answerMessages.DefaultIfEmpty()
                              join answerUser in context.Users! on answerMessage.UserId equals answerUser.Id
                              into answerUsers
                              from answerUser in answerUsers.DefaultIfEmpty()
                              join answerUserRank in context.Ranks! on answerUser.RankId equals answerUserRank.Id
                              into answerUserRanks
                              from answerUserRank in answerUserRanks.DefaultIfEmpty()
                              select new MessageDto
                              {
                                  Id = message.Id,
                                  PostId = message.PostId,
                                  User = new PostUserDto
                                  {
                                      UserId = user.Id,
                                      Username = user.Username,
                                      Fullname = user.Fullname,
                                      Rank = rank,
                                      Image = user.Image
                                  },
                                  AnswerMessage = answerMessage != null ? new AnswerMessageDto
                                  {
                                      Id = answerMessage.Id,
                                      User = answerUser != null ? new PostUserDto
                                      {
                                          UserId = answerUser.Id,
                                          Username = answerUser.Username,
                                          Fullname = answerUser.Fullname,
                                          Rank = answerUserRank,
                                          Image = answerUser.Image
                                      } : null!,
                                      Content = answerMessage.Content,
                                      CreatedDate = answerMessage.CreatedDate
                                  } : null!,
                                  Content = message.Content,
                                  CreatedDate = message.CreatedDate
                              }).ToList();

                return result;
            }


        }
    }
}
