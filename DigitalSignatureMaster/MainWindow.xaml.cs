using DigitalSignatureMaster.VM;
using DigitalSignatureMaster.VM.DialogService;
using DigitalSignatureMaster.VM.FileService;
using System.Windows;
namespace DigitalSignatureMaster
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            DataContext = new SignFileVM(new OpenDialogService(), new SaveDialogService(), new ByteReadFileService(), new StreamWriterFileService());
        }
    }
}
