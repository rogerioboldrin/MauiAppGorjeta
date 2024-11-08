namespace MauiAppGorjeta
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        } 

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double valorConta = Convert.ToDouble(entValorConta.Text);
            double perGorjeta = Convert.ToDouble(entPerGorjeta.Text);
            double valorGorjeta = valorConta * perGorjeta/100;
            double total = valorGorjeta + valorConta;
            

            lbValorGorjeta.Text = "R$" + valorConta.ToString("F2");
            lbValorTotal.Text = "R$" + total.ToString("F2");
            lbGorjeta.Text = valorGorjeta.ToString("F2");

            



        }
    }

}
