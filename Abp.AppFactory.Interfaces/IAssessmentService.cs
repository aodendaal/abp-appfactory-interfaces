using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentService
    {
        Task CancelAsync(int assessmentId);

        Task<List<IAssessmentCampaign>> GetCampaignsAsync();

        Task<IAssessmentResult> GetStatusAsync(string assessmentId, string assessmentResultId);

        Task<IAssessmentLink> GetAssessmentAsync(string campaignId, Guid userToken, IEnumerable<string> tags = null);
    }
}