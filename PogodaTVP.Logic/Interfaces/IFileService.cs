using System.IO;
using System.Net;

namespace PogodaTVP.Logic.Interfaces
{
    public interface IFileService
    {
        FileInfo CreateFileFromHttpResponse(HttpWebResponse httpWebResponse);
        FileInfo ExtractFile(FileInfo fullFileName);
        FileInfo ZippFile(FileInfo fileToZipping);
        FileInfo ChangeFileExtensionToMogrt(FileInfo fullFileName);
    }
}
