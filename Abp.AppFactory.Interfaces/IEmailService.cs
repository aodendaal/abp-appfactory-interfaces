using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IEmailService
    {
        Task<IEmailResponse> SendAsync(ISendGridEmail email);
    }
}