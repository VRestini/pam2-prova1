namespace Prova
{
    public partial class MainPage : ContentPage
    {
        int number = 0;
        int limit = 0;
       
        Random rdn = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollClicked(object sender, EventArgs e)
        {
            limit = Convert.ToInt32((string)picker.SelectedItem);
            number = rdn.Next(1, limit + 1);
            Numb.Text = number.ToString();
            
        }

        
    }

}
