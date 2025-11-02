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
            List<string> animals = ["🐱", "🐱", "🐶", "🐶", "🐭", "🐭", "🦊", "🦊", "🐯", "🐯", "🦁", "🦁", "🐷", "🐷", "🐸", "🐸"];

            foreach (var button in AnimalButtons.Children.OfType<Button>())
            {
                int index = new Random().Next(animals.Count);
                button.Text = animals[index];
                animals.RemoveAt(index);
                button.IsEnabled = true;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }

}
