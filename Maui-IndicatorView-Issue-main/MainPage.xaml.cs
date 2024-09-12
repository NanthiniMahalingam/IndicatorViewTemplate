using System.ComponentModel;

namespace TestCarouselView;

public partial class MainPage : ContentPage
{
    private readonly IReadOnlyList<string> _imageSource1 = new List<string>
    {
            "dotnet_bot.png",
            "dotnet_bot.png",
            "dotnet_bot.png",
            "dotnet_bot.png",
            "dotnet_bot.png",
    };
    private readonly IReadOnlyList<string> _imageSource2 = new List<string>() 
    {
            "dotnet_bot.png",
            "dotnet_bot.png",
            "dotnet_bot.png",
            "dotnet_bot.png",
            "dotnet_bot.png",
            "dotnet_bot.png",
    };
    private IReadOnlyList<string> _images = [];
    public IReadOnlyList<string> Images
    {
        get => _images;
        set
        {
            if (Equals(value, _images)) return;
            _images = value;
            OnPropertyChanged();
        }
    }
    
    public MainPage()
    {
        InitializeComponent();
        Images = _imageSource1;
    }

    private void OnChangeSourceClicked(object sender, EventArgs e)
    {
        if (Images?.Count == 6)
        {
            Images = _imageSource1;
        }
        else
        {
            Images = _imageSource2;
        }
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        IndicatorView.IndicatorSize = 25;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        IndicatorView.IndicatorSize = 30;
    }
}