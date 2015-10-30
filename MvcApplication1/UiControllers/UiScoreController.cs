using DonnBusiness.BusinessLogic.Interface;
using DonnDomain.Objects;
using DonnWeb.Models.Score;
using DonnWeb.UIMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.UiControllers
{
    public class UiScoreController
    {
        private IScoreLogic _logic;
        private ITotalScoreMapper _mapper;

        public UiScoreController(IScoreLogic logic, ITotalScoreMapper mapper)
        {
            _logic = logic;
            _mapper = mapper;
        }

        public TotalScore GetModel()
        {
            var model = _mapper.MapDomainToViewModel(_logic.GetLatestScore()); // Don't really like this.. Having the mapper always populate Percentage as 0.00;
            model.CurrentScorePercentage = _logic.GetScorePercentage(model.CurrentScore, model.MaxScore);
            return model;
        }
    }
}