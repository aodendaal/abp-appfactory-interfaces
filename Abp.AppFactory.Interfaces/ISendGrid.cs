using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface ISendGrid
    {
        Task<ISendGridResponse> SendAsync(ISendGridEmail email);
    }
}