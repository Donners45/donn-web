using DonnBusiness.BusinessLogic.Cache;
using DonnBusiness.BusinessLogic.Interface;
using DonnDomain.Interfaces;
using DonnDomain.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnBusiness.BusinessLogic.Implementations
{
    public class ScoreLogic : InMemoryCacheBase<IEnumerable<TotalScoreDomain>>, IScoreLogic
    {
        IScoreAdaptor _adaptor;

        public ScoreLogic(IScoreAdaptor adaptor)
        {
            _adaptor = adaptor;
        }

        public IEnumerable<TotalScoreDomain> GetAllScores()
        {
            var scores = Get("Scores.AllScores.NoOrder");
            return scores.OrderByDescending(x => x.Updated);
        }

        public TotalScoreDomain GetLatestScore()
        {
            return _adaptor.GetLatestScore();
        }

        public override IEnumerable<TotalScoreDomain> GetFromRepository()
        {
            return _adaptor.GetAllScores();
        }
    }
}
