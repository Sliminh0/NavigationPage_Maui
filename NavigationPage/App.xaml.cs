namespace NavigationPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {

            //Cria uma nova janela com a página principal dentro de uma mainpage
            return new Window(new Microsoft.Maui.Controls.NavigationPage(new MainPage())); 
            
        }
    }
}