using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DigitalSignatureMaster.VM.FileService
{
    public class StreamWriterFileService: IWriteFileService
    {
        public void WriteFile(string filePath, byte[] fileContent)
        {

            using (var signStream = new StreamWriter(filePath))
            {
                signStream.WriteLine(BitConverter.ToString(fileContent));
            }
        }
    }
}
