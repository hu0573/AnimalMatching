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

        Button lastClicked;
        bool findingMatch = false;
        int matchesFound;

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button buttonClicked)
            {
                if (!string.IsNullOrWhiteSpace(buttonClicked.Text) && (findingMatch == false))
                {
                    buttonClicked.BackgroundColor = Colors.Red;
                    lastClicked = buttonClicked;
                    findingMatch = true;
                }
                else
                {
                    if ((buttonClicked != lastClicked) && (buttonClicked.Text == lastClicked.Text)
                         && (!String.IsNullOrWhiteSpace(buttonClicked.Text)))
                    {
                        matchesFound++;
                        lastClicked.Text = " ";
                        buttonClicked.Text = " ";
                    }
                    lastClicked.BackgroundColor = Colors.LightBlue;
                    buttonClicked.BackgroundColor = Colors.LightBlue;
                    findingMatch = false;
                }
            }

            if (matchesFound == 8)
            {
                matchesFound = 0;
                AnimalButtons.IsVisible = false;
                PlayAgainButton.IsVisible = true;
            }
        }

    }

}
