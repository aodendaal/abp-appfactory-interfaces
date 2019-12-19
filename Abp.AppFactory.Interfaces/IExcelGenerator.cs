using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abp.AppFactory.Interfaces
{
    public interface IExcelGenerator
    {
        Task<string> CreateAndStoreAsync<T>(IEnumerable<T> content, string filename = "export.xlsx", string worksheetTitle = "Sheet1");
        Task<string> CreateAndStoreAsync<T>(IEnumerable<T> content, string[] headings, string filename = "export.xlsx", string worksheetTitle = "Sheet1");
        Task<string> CreateAndStoreAsync<T>(IEnumerable<T> content, IBlobStorage blobStorage, string containerName, string directory = null, string filename = "export.xlsx", string worksheetTitle = "Sheet1");
        Task<string> CreateAndStoreAsync<T>(IEnumerable<T> content, string[] headings, IBlobStorage blobStorage, string containerName, string directory = null, string filename = "export.xlsx", string worksheetTitle = "Sheet1");

        Task<byte[]> CreateAsync<T>(IEnumerable<T> content, string worksheetTitle = "Sheet1");
        Task<byte[]> CreateAsync<T>(IEnumerable<T> content, string[] headings, string worksheetTitle = "Sheet1");

        void SetStore(IBlobStorage blobStorage, string containerName, string directory = null);
    }
}
