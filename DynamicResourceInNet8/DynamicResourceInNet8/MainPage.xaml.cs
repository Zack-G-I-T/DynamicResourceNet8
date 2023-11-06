using DynamicResourceInNet8.Resources.Themes;

namespace DynamicResourceInNet8
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Light;
        }


        public void ChangeTheme(object sender, EventArgs e)
        {
            if (Application.Current.UserAppTheme == AppTheme.Dark)
                SetLightTheme();
            else
                SetDarkTheme();
        }

        private void SetLightTheme()
        {
            Application.Current?.Resources.MergedDictionaries.Remove(DarkTheme.SharedInstance);
            Application.Current?.Resources.MergedDictionaries.Add(LightTheme.SharedInstance);
            if (Application.Current != null) Application.Current.UserAppTheme = AppTheme.Light;
        }

        private void SetDarkTheme()
        {
            Application.Current?.Resources.MergedDictionaries.Remove(LightTheme.SharedInstance);
            Application.Current?.Resources.MergedDictionaries.Add(DarkTheme.SharedInstance);
            if (Application.Current != null) Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }

}
