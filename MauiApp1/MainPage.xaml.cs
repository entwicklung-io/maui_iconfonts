namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        var fontImageSource = new FontImageSource();
        fontImageSource.FontFamily = "iconfont";
        fontImageSource.Glyph = Convert.ToChar(Convert.ToUInt32($"0x{0xe00b.ToString("X4").ToUpper()}", 16)).ToString();
        fontImageSource.Color = Colors.Fuchsia;
        fontImageSource.Size = 100;

        FontImage.Source = fontImageSource;
    }
}