using DigitalSignatureMaster.VM.DialogService;
using DigitalSignatureMaster.VM.FileService;
using Cryptographic;

namespace DigitalSignatureMaster.VM
{
    public class SignFileVM
    {
        private RelayCommand? signCommand;
        private readonly IReadFileService readFileService;
        private readonly IWriteFileService writeFileService;

        public FileSelectorVM File { set; get; }
        public FileSelectorVM Sign { set; get; }
        public FileSelectorVM Cert { set; get; }

        public SignFileVM(IDialogService openDialogService, IDialogService saveDialogService, IReadFileService readFileService, 
            IWriteFileService writeFileService)
        {
            File = new FileSelectorVM(openDialogService);
            Cert = new FileSelectorVM(openDialogService);
            Sign = new FileSelectorVM(saveDialogService);

            this.readFileService = readFileService;
            this.writeFileService = writeFileService;
        }

        public RelayCommand SignCommand
        {
            get
            {
                return signCommand ??
                  (signCommand = new RelayCommand(obj =>
                  {
                      var sign = new DigitalSignature();
                      writeFileService.WriteFile(Sign.FilePath, 
                          sign.SignMessage(readFileService.ReadFile(File.FilePath),
                          new System.Numerics.BigInteger(readFileService.ReadFile(Cert.FilePath))));
                  }));
            }
        }

    }
}
