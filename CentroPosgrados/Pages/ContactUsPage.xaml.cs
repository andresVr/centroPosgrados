using System;
using System.Collections.Generic;
using Plugin.Messaging;
using Xamarin.Forms;

namespace CentroPosgrados.Pages
{
    public partial class ContactUsPage : ContentPage
    {
        public ContactUsPage()
        {
            InitializeComponent();
        }
		private void emailClick(object sender, EventArgs e)
		{
			var emailMessenger = CrossMessaging.Current.EmailMessenger;
			if (emailMessenger.CanSendEmail)
			{
				var email = new EmailMessageBuilder()
					.To("acbonifaz@espe.edu.ec")
					.Subject("Messange receptado por la APP Posgrados")
					.Body("Aquí su texto")
					.Build();

				emailMessenger.SendEmail(email);
			}

		}
		private void phoneCallClick(object sender, EventArgs e)
		{
			var phoneCalltask = CrossMessaging.Current.PhoneDialer;
			if (phoneCalltask.CanMakePhoneCall)
			{
				phoneCalltask.MakePhoneCall("0223989400", "ESPE");
			}
		}

	}
}
