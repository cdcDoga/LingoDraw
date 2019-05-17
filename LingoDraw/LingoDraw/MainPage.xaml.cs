using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LingoDraw
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            imgLogo.Source = ImageSource.FromResource("LingoDraw.language_logo.png");

            btnLearn.Clicked += async (sender, args) => await Navigation.PushModalAsync(new LearnPage());
            btnPractice.Clicked += async (sender, args) => await Navigation.PushModalAsync(new PracticePage());
        }
    }
}
