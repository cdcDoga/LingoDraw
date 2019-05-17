using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LingoDraw
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PracticePage : ContentPage
	{
		public PracticePage ()
		{
			InitializeComponent ();

            Random rnd = new Random();
            int num = rnd.Next(3, 49);  // creates a number between 1 and 48
            imgEditor.BackgroundImage = ImageSource.FromResource("LingoDraw.hiragana.h" + num + ".PNG");

            btnHome.Clicked += async (sender, args) => await Navigation.PopModalAsync();
            btnNext.Clicked += (sender, args) =>
            {
                imgEditor.Clear();

                rnd = new Random();
                num = rnd.Next(3, 49);  // creates a number between 1 and 48
                imgEditor.BackgroundImage = ImageSource.FromResource("LingoDraw.hiragana.h" + num + ".PNG");
                //DisplayAlert("Control", num.ToString(), "OK");
            };
        }
	}
}