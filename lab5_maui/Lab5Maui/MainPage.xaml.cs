using Lab5Maui.ViewModels;

namespace Lab5Maui;

public partial class MainPage : ContentPage
{
    private readonly MainViewModel _vm = new();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = _vm;
    }

    private void Add_Clicked(object sender, EventArgs e) => _vm.AddSample();
    private void Remove_Clicked(object sender, EventArgs e) => _vm.RemoveLast();
}