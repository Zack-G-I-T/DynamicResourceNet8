namespace DynamicResourceInNet8.Resources.Themes;

public partial class DarkTheme : ResourceDictionary
{
    public static DarkTheme SharedInstance { get; } = new DarkTheme();
    public DarkTheme()
    {
        InitializeComponent();
    }
}