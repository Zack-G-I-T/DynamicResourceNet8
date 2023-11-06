namespace DynamicResourceInNet8.Resources.Themes;

public partial class LightTheme : ResourceDictionary
{
    public static LightTheme SharedInstance { get; } = new LightTheme();
    public LightTheme()
    {
        InitializeComponent();
    }
}