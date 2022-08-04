using System;
using System.Collections.Generic;
using System.Text;
using Avalonia.Controls;
using ForLeonid.MainWindow;
using ReactiveUI.Fody.Helpers;

namespace ForLeonid.ViewModels
{
    public class MainWindowViewModel : ViewModelBase,iMainWindow
    {
        private GlobalVariable globalVariable;
        public MainWindowViewModel()
        {
            globalVariable=GlobalVariable.GetGlobalVariable();
            globalVariable.MainWindow= this;
        }
        [Reactive] internal UserControl Content { get; set; }

        void iMainWindow.SetContent(UserControl content)
        {
            Content = content;
        }
    }
}
