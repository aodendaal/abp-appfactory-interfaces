using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface ISendGrid
    {
        Task<ISendGridResponse> Send(IEmail email);
    }
}