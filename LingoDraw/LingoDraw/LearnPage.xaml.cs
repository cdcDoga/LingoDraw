using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LingoDraw
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LearnPage : ContentPage
	{
		public LearnPage ()
		{
			InitializeComponent ();

            imgSeiOn.Source = ImageSource.FromResource("LingoDraw.hiragana.s1.PNG");

            imgDakuOn1.Source = ImageSource.FromResource("LingoDraw.hiragana.s2.PNG");
            imgDakuOn2.Source = ImageSource.FromResource("LingoDraw.hiragana.s3.PNG");

            imgYoOn1.Source = ImageSource.FromResource("LingoDraw.hiragana.s4.PNG");
            imgYoOn2.Source = ImageSource.FromResource("LingoDraw.hiragana.s5.PNG");
            imgYoOn3.Source = ImageSource.FromResource("LingoDraw.hiragana.s6.PNG");

            btnHome.Clicked += async (sender, args) => await Navigation.PopModalAsync();
        }
	}
}