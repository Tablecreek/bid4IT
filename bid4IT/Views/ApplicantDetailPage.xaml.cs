using BusinessLayer.Models.Database;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace bid4IT.Views
{
    public sealed partial class ApplicantDetailPage : Page
    {
        bool changesMade = false;

        Person applicant;


        public ApplicantDetailPage()
        {
            InitializeComponent();

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter == null)
            {
                applicant = new Person();
                return;
            }

            var passedApplicant = (Person) e.Parameter;
            applicant = passedApplicant;


        }

        private void SaveApplicantAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Save applicant
        }

        private async void CancelAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            if (changesMade) {
                var dialog = new Windows.UI.Popups.MessageDialog("If you don't save all changes will be lost! Do you really want to exit edit mode?");

                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Exit edit mode") { Id = 0 });
                dialog.Commands.Add(new Windows.UI.Popups.UICommand("Cancel") { Id = 1 });

                dialog.DefaultCommandIndex = 0;
                dialog.CancelCommandIndex = 1;

                var result = await dialog.ShowAsync();

                if ((int)result.Id == dialog.DefaultCommandIndex)
                {
                    Frame.Navigate(typeof(ApplicantsPage));
                }
           }
        }
    }
}
