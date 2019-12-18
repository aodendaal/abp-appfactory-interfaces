using System;
using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface ISyncHub
    {
        IAssessmentTask Sync(Type entityType);
    }
}
