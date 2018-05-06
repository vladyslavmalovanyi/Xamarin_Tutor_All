using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Tutor_All
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
        private static int pos = 0;
        private static string[] phrases = {
            "Few are those who see with their own eyes and feel with their own hearts.",
            "Imagination is more important than knowledge. Knowledge is limited. Imagination encircles the world.",
            "Unthinking respect for authority is the greatest enemy of truth.",
            "Try not to become a man of success, but rather try to become a man of value.",
            "In the middle of difficulty lies opportunity."
        };

        public QuotesPage()
        {
            InitializeComponent();
            label.Text = phrases[pos];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (pos < phrases.Length - 1) { pos++; }
            else { pos = 0; }

            label.Text = phrases[pos];
        }
    }
}