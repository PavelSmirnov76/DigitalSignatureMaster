using System.Numerics;

namespace DigitalSignatureMaster.VM.FileService
{
    public interface IReadFileService
    {
       byte[] ReadFile(string filePath);     
    }
}
