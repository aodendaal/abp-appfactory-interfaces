using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.AppFactory.Interfaces
{
    public interface IAssessmentLink
    {
        string Id { get; set; }
        string InvitationUrl { get; set; }
    }
}
