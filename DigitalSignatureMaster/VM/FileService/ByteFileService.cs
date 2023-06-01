using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace DigitalSignatureMaster.VM.FileService
{
    public class ByteReadFileService : IReadFileService
    {
        public byte[] ReadFile(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }
    }
}
