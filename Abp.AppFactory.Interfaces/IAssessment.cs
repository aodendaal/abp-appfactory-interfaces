using System.Collections.Generic;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessment
    {
        string Id { get; set; }
        string Title { get; set; }
        string IntroMessage { get; set; }
        string OutroMessage { get; set; }
        int? Duration { get; set; }
        IList<IAssessmentReport> Reports { get; set; }
    }
}