using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.DTOs;
using Repositories.Concretes.EntityFramework;
using Services.Abstracts;

namespace Services.Concretes
{
    public class StatisticsManager : IStatisticsService
    {
        public IDataResult<FForumStatisticsDto> GetStatistics()
        {
            using var context = new FForumContext();
            var result = new FForumStatisticsDto
            {
                PostCount = context.Posts!.Count(),
                MessageCount = context.Messages!.Count(),
                UserCount = context.Users!.Count()
            };
            return new SuccessDataResult<FForumStatisticsDto>(result);
        }
    }
}
