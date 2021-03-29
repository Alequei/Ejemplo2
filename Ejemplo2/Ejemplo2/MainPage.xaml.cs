using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejemplo2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());
            };
            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage1());
            };
            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CarouselPage1());
            };
            Item5.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ModalPage1());
            };
            Item6.Clicked += async (sender, e) =>
            {
                var answer = await DisplayAlert
                ("Question?", "World you like to play a game ", "Yes", "NO");
                Debug.WriteLine("Answer:" + answer);
            };
        }
    }
}
