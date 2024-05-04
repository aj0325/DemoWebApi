namespace Demo.DemoCBIA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzIzOTQyNUAzMjM1MmUzMDJlMzBKWDdhK20xT2VJTGhJcHpuQjV5TXNsM3lMdjZJbVhmT09xYVRXMEd1ZkhJPQ==");
            MainPage = new AppShell();
        }
    }
}