using Microsoft.Extensions.DependencyInjection;

namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzg5MDM1NkAzMjM5MmUzMDJlMzAzYjMzMzczYmhub3hvMEVqZEUzZnM0K2NyY2VQaGNjZG4wdHcwWGx2YzdQNVdQaHdQNzA9");
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}