using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private ObservableCollection<string> _items = ["Item 1", "Item 2", "Item 3"];
    private ObservableCollection<string> _items2 = ["Item 1", "Item 2", "Item 3"];

    public MainPage()
    {
        InitializeComponent();
        ComboBox.ItemsSource = _items;
        // The reproduce the issue in ComboBox2, we start with a populated collection
        ComboBox2.ItemsSource = _items2;
        // The reproduce the issue in ComboBox3, we start with an empty collection
        ComboBox3.ItemsSource = new ObservableCollection<string>();

        // Ensure collection updates happen on the UI thread to avoid Android layout issues
        Task.Run(async () =>
        {
            await Task.Delay(3000);

            // Add items to the second ComboBox
            _items2.Add("Item 5");
            _items2.Add("Item 6");
            _items2.Add("Item 7");
            
            // Add items to the third ComboBox by resetting its ItemsSource
            ComboBox3.ItemsSource = _items2;
            
            // Add items to the fourth ComboBox by resetting its ItemsSource. Since the ItemsSource is empty, it should work.
            ComboBox4.ItemsSource = _items2;
        });
    }
    
}