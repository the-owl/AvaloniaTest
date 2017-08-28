using System;
using ReactiveUI;

namespace AvaloniaTest
{
    public class MainWindowViewModel : ReactiveObject
    {
        public MainWindowViewModel()
        {
            OpenFile = ReactiveCommand.Create();
        }

        public ReactiveCommand<object> OpenFile { get; }
    }
}
