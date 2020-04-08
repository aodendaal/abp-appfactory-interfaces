using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface ISendGrid: IEmailService
    {
        new Task<ISendGridResponse> SendAsync(ISendGridEmail email);
    }
}