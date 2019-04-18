using System;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentResult
    {
        AssessmentStatusType Status { get; set; }
        IAssessmentLink Assessment { get; set; }
        IAssessmentReport Report { get; set; }
        DateTime Sent { get; set; }
        DateTime? Start { get; set; }
        DateTime? End { get; set; }
        string DashboardURL { get; set; }
    }
}