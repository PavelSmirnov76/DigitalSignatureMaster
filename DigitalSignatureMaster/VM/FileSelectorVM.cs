using DigitalSignatureMaster.VM.DialogService;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace DigitalSignatureMaster.VM
{
    public class FileSelectorVM : INotifyPropertyChanged
    {
        private string filePath;
        private RelayCommand? selectCommand;
        readonly IDialogService dialogService;

        public string FilePath 
        { 
            set
            {
                filePath = value;
                OnPropertyChanged("FilePath");
            }
            get 
            {
                return filePath;
            } 
        }

        public FileSelectorVM(IDialogService dialogService)
        {
            this.dialogService = dialogService;
            this.filePath = "";
        }

        public RelayCommand SelectCommand
        {
            get
            {
                return selectCommand ??
                  (selectCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.OpenFileDialog() == true)
                          {
                              FilePath = dialogService.FilePath != null? dialogService.FilePath: throw new Exception("файл не найден.");                          
                          }
                      }
                      catch(Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }
                  }));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
