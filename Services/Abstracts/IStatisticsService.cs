using Core.Utilities.Results.Abstracts;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstracts
{
    public interface IStatisticsService
    {
        IDataResult<FForumStatisticsDto>  GetStatistics();
    }
}
