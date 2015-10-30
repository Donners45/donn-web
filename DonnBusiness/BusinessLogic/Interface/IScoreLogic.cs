using DonnDomain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnBusiness.BusinessLogic.Interface
{
    public interface IScoreLogic
    {
        IEnumerable<TotalScoreDomain> GetAllScores();
        TotalScoreDomain GetLatestScore();
        double GetScorePercentage(double currentScore, double maxScore);
    }
}
