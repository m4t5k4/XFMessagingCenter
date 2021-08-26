using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFMessagingCenter
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Messages { get; set; } = new ObservableCollection<string>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<Page, DateTime>(this, "tick", (p, dateTime) =>
            {
                Messages.Add($"Message received at {dateTime}");
            });
        }

        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SendPage());
        }
    }
}
