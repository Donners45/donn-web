using DonnDomain.Objects;
using DonnWeb.Models.Score;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.UIMappers
{
    public class TotalScoreMapper : ITotalScoreMapper
    {

        public TotalScore MapDomainToViewModel(TotalScoreDomain domain)
        {
           return new TotalScore
            {
                CurrentScore = domain.CurrentScore,
                Updated = domain.Updated,
                MaxScore = 1000000,
                MinScore = 0,
                CurrentScorePercentage = 0
            };
           
        }

    }
}