﻿namespace MauiAppLukaszD
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Random r = new Random();

            int diceRoll = r.Next(1, 7);

            RollValueLabel.Text = "Wylosowany rzut: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
        private void OnCounterClicked1(object sender, EventArgs e)
        {
            Random r = new Random();

            int diceRoll = r.Next(1, 5);

            RollValueLabel.Text = "Wylosowany rzut: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn1.Text);
        }
        private void OnCounterClicked2(object sender, EventArgs e)
        {
            Random r = new Random();

            int diceRoll = r.Next(1, 13);

            RollValueLabel.Text = "Wylosowany rzut: " + diceRoll.ToString();

            SemanticScreenReader.Announce(CounterBtn2.Text);
        }

    }

}
