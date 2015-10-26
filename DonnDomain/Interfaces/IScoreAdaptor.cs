using DonnDomain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnDomain.Interfaces
{
    public interface IScoreAdaptor
    {
        TotalScoreDomain GetLatestScore();
        IEnumerable<TotalScoreDomain> GetAllScores();
    }
}
