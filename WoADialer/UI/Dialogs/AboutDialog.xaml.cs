﻿using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WoADialer.Helpers;
using WoADialer.UI.ViewModel;

namespace WoADialer.UI.Dialogs
{
    public sealed partial class AboutDialog : ContentDialog
    {
        public AboutViewModel ViewModel { get; }

        public AboutDialog()
        {
            RequestedTheme = (Window.Current.Content as FrameworkElement).RequestedTheme;
            this.InitializeComponent();
            ViewModel = new AboutViewModel(Dispatcher);
        }

        private ICommand _closeDialogCommand;
        public ICommand CloseDialogCommand
        {
            get
            {
                if (_closeDialogCommand == null)
                {
                    _closeDialogCommand = new RelayCommand(
                        () =>
                        {
                            Hide();
                        });
                }
                return _closeDialogCommand;
            }
        }


    }
}
