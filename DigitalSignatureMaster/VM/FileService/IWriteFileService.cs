using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignatureMaster.VM.FileService
{
    public interface IWriteFileService
    {
        void WriteFile(string filePath, byte[] fileContent);
    }
}
