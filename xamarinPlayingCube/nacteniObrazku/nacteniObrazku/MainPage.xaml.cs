using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace nacteniObrazku
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Callling objects after click button
        private void Button_Clicked(object sender, EventArgs e)
        {
            //generate random picture from list
            Random random = new Random();
            string[] pictures = { "jedna.jpg", "dva.jpg", "tri.jpg", "ctyri.jpg", "pet.jpg", "sest.jpg"};
            imgLogo.Source = ImageSource.FromFile(pictures[random.Next(6)]);

        }
    }
}
