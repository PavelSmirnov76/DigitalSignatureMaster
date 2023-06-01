using Microsoft.Win32;
using System;
using System.Collections.Generic;
namespace DigitalSignatureMaster.VM.DialogService
{
    public class SaveDialogService : IDialogService
    {
        public string? FilePath { get; set; }

        public bool OpenFileDialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                FilePath = saveFileDialog.FileName;
                return true;
            }
            return false;
        }
    }
}
