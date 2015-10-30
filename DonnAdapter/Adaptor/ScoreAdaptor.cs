using DonnDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonnDomain.Objects;
namespace DonnAdapter.Adaptor
{
   public class ScoreAdaptor : IScoreAdaptor
   {
       public TotalScoreDomain GetLatestScore()
       {
           return new TotalScoreDomain() { Updated = DateTime.Now, CurrentScore = 600000};
       }

       public IEnumerable<TotalScoreDomain> GetAllScores()
       {
           throw new NotImplementedException();
       }
   }
}
