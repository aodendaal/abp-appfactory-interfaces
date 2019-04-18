using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentService
    {
        Task Cancel(int assessmentId);

        Task<List<IAssessmentCampaign>> GetCampaigns();

        Task<IAssessmentResult> GetStatus(int assessmentId);

        Task<IAssessmentLink> GetAssessment(int campaignId, Guid userToken, IEnumerable<string> tags = null);
    }
}