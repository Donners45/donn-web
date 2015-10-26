using DonnBusiness.BusinessLogic.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.UiControllers
{
    public class UiScoreController
    {
        private IScoreLogic _logic;

        public UiScoreController(IScoreLogic logic)
        {
            _logic = logic;
        }



    }
}