using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IBlobStorage
    {
        string Endpoint { get; }
        Task UploadAsync(string containerName, string filename, byte[] file);
        Task UploadAsync(string containerName, string directory, string filename, byte[] file);
    }
}
