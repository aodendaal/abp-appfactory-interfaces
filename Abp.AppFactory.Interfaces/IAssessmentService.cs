using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentService
    {
        Task CancelAsync(int assessmentId);

        Task<List<IAssessmentCampaign>> GetCampaignsAsync();

        Task<IAssessmentResult> GetStatusAsync(int assessmentId);

        Task<IAssessmentLink> GetAssessmentAsync(int campaignId, Guid userToken, IEnumerable<string> tags = null);
    }
}