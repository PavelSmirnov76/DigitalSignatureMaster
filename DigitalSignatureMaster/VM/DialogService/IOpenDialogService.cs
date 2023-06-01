namespace DigitalSignatureMaster.VM.DialogService
{
    public interface IDialogService
    {
        string? FilePath { get; set; }
        bool OpenFileDialog();
    }
}
