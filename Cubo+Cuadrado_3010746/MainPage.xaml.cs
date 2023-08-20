namespace Cubo_Cuadrado_3010746
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(N.Text);

            cuadra.Text = "Número al cuadrado: " + Math.Pow(num, 2);
            cubo.Text = "Número al cubo: " + Math.Pow(num, 3);
        }
    }
}