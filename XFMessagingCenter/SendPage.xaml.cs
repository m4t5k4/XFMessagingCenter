using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFMessagingCenter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SendPage : ContentPage
    {
        public SendPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<Page, DateTime>(this, "tick", DateTime.Now);
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}