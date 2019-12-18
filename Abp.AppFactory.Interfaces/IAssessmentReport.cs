using System;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentReport
    {
        string Id { get; set; }
        AssessmentStatus Status { get; set; }
        Guid UserToken { get; set; }
        int MaxScore { get; set; }
        DateTime StartDate { get; set; }
        DateTime FinishDate { get; set; }
        IAssessmentResult Result { get; set; }
        string InvitationUrl { get; set; }
    }
}