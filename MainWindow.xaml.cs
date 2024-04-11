using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RepairManagementSystem
{
    public partial class MainWindow : Window
    {
        private readonly RepairRequestsViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new RepairRequestsViewModel();
            DataContext = _viewModel;
            Closing += MainWindow_Closing;
        }

        private void AddRequest_Click(object sender, RoutedEventArgs e)
        {

            var request = new RepairRequest
            {
                RequestNumber = _viewModel.RepairRequests.Count + 1,
                DateAdded = DateTime.Now,
                DeviceName = txtDeviceName.Text,
                IssueType = txtIssueType.Text,
                IssueDescription = txtIssueDescription.Text,
                ClientName = txtClientName.Text,
                Status = "Pending"
            };

            _viewModel.AddRepairRequest(request);

            // Clear input fields
            txtDeviceName.Clear();
            txtIssueType.Clear();
            txtIssueDescription.Clear();
            txtClientName.Clear();

        }
        private void StatusTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as TextBox;
            var request = textBox.DataContext as RepairRequest;
            request.Status = textBox.Text;
        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Здесь будет код сохранения данных
        }
    }
    }  



