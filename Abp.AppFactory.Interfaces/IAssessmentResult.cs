using System.Collections.Generic;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentResult
    {
        int Score { get; set; }
        IList<IAssessmentTask> Tasks { get; set; }
    }
}