using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DonnWeb.Models.Score
{
    public class TotalScore
    {
        public DateTime Updated { get; set; }
        public double CurrentScore { get; set; }
        public double MaxScore { get; set; }
        public double MinScore { get; set; }
        public double CurrentScorePercentage { get; set; }
    }
}