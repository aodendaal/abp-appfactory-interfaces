using System.Collections.Generic;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentTechnology
    {
        string Name { get; set; }
        int Points { get; set; }
        int TotalPoints { get; set; }
        double Score { get; set; }
        List<IAssessmentSkill> Skills { get; set; }
    }
}