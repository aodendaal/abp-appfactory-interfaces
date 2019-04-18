using System;
using System.Collections.Generic;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentReport
    {
        TimeSpan Duration { get; set; }
        TimeSpan TotalDuration { get; set; }
        List<string> Warnings { get; set; }
        List<IAssessmentTechnology> Technologies { get; set; }
        int Points { get; set; }
        int TotalPoints { get; set; }
        double Score { get; set; }
        double WeightedScore { get; set; }
    }
}