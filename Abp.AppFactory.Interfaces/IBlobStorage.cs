using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IBlobStorage
    {
        string Endpoint { get; }
        Task<string> UploadAsync(string containerName, string filename, byte[] file);
        Task<string> UploadAsync(string containerName, string directory, string filename, byte[] file);
        IAssessmentTask DeleteAsync(string containerName, string directory, string filename);
    }
}
