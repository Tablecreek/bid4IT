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
using BusinessLayer.Models.Database;

namespace bid4IT.Views
{
    public sealed partial class ApplicantsPage : Page
    {
        private List<Person> applicants = new List<Person>();
        private List<Person> filteredApplicants = new List<Person>();

        public ApplicantsPage()
        {
            InitializeComponent();

            BusinessLayer.ApplicantDataService applicantDataService = new BusinessLayer.ApplicantDataService();

            applicants = applicantDataService.GetAllApplicants();

            ApplicantsListView.ItemsSource = applicants;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void AddApplicantAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ApplicantDetailPage));
        }

        private void TasksMenuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void ApplicantsMenuItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(ApplicantsPage));
        }

        private void ApplicantSearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            filteredApplicants = new List<Person>();

            var senderTextBox = (TextBox)sender;

            if (senderTextBox.Text.Equals(""))
            {
                ApplicantsListView.ItemsSource = applicants;
            }

            foreach (var applicant in applicants)
            {
                if (applicant.FirstName.ToLower().Contains(senderTextBox.Text.ToLower())){
                    filteredApplicants.Add(applicant);
                    continue;
                }

                if (applicant.LastName.ToLower().Contains(senderTextBox.Text.ToLower())){
                    filteredApplicants.Add(applicant);
                    continue;
                }

                var fullName = applicant.FirstName + " " + applicant.LastName;
                if (fullName.ToLower().Contains(senderTextBox.Text.ToLower())){
                    filteredApplicants.Add(applicant);
                    continue;
                }
            }
            
            ApplicantsListView.ItemsSource = filteredApplicants;
        }

        private void ApplicantsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var applicant = (Person)ApplicantsListView.SelectedItem;

            if (applicant != null)
            {
                Frame.Navigate(typeof(ApplicantDetailPage), applicant);
            }
        }
    }
}
