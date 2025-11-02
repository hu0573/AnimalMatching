namespace AnimalMatching
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            TimeElapsed.IsVisible = true;
            AnimalButtons.IsVisible = true;
            PlayAgainButton.IsVisible = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

}
