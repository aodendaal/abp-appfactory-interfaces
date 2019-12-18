using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentService
    {
        Task<IList<IAssessmentLink>> GetAssessmentLinkAsync(string campaignId, Guid userToken);
        Task<IList<IAssessment>> GetAssessmentAsync(string campaignId);
    }
}