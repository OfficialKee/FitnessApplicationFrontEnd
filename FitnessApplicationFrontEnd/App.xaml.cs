using FitnessApplicationFrontEnd.Pages;

namespace FitnessApplicationFrontEnd
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();


        }
    }
}
