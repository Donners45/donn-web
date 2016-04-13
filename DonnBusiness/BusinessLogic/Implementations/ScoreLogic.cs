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
    public class ScoreLogic : IScoreLogic
    {
        IScoreAdaptor _adaptor;
        private readonly ICacheService _cache;

        public ScoreLogic(IScoreAdaptor adaptor, ICacheService cache)
        {
            _adaptor = adaptor;
            _cache = cache;
        }

        public IEnumerable<TotalScoreDomain> GetAllScores()
        {
            var scores = _cache.This("Scores.AllScores.NoOrder", GetAllFromRepository);
            return scores.OrderByDescending(x => x.Updated);
        }

        public TotalScoreDomain GetLatestScore()
        {
            return _adaptor.GetLatestScore();
        }

        private IEnumerable<TotalScoreDomain> GetAllFromRepository()
        {
            return _adaptor.GetAllScores();
        }

        public double GetScorePercentage(double currentScore, double maxScore)
        {
            return currentScore / maxScore * 100;
        }

    }
}
