using System;
using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentService
    {
        Task<IAssessment> GetAssessmentAsync(string assessmentId);

        Task<IAssessmentLink> GetAssessmentLinkAsync(string assessmentId, Guid userToken);
    }
}