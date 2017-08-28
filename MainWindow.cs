using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using ReactiveUI;
using System;

namespace AvaloniaTest
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            var vm = new MainWindowViewModel();
            vm.OpenFile.Subscribe(_ => this.Open());
            this.DataContext = vm;
        }

        private async void Open () {
            var openDialog = new OpenFileDialog();
            openDialog.Title = "Test";
            openDialog.AllowMultiple = false;

            var files = await openDialog.ShowAsync(this);
            if (files != null && files.Length != 0) {
                Console.WriteLine(files[0]);
            }
        }
    }
}