namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                // Switch to dark theme
                Application.Current.UserAppTheme = AppTheme.Dark;
            }
            else
            {
                // Switch to light theme
                Application.Current.UserAppTheme = AppTheme.Light;
            }
        }
    }

}
