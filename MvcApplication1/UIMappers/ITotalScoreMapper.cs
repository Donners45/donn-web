using DonnDomain.Objects;
using DonnWeb.Models.Score;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonnWeb.UIMappers
{
    public interface ITotalScoreMapper
    {
        TotalScore MapDomainToViewModel(TotalScoreDomain domain);
    }
}
