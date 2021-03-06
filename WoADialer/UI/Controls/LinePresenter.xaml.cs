﻿using Internal.Windows.Calls;
using Windows.ApplicationModel.Calls;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using WoADialer.UI.ViewModel;

// Документацию по шаблону элемента "Пользовательский элемент управления" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234236

namespace WoADialer.UI.Controls
{
    public sealed partial class LinePresenter : UserControl
    {
        public static readonly DependencyProperty PresentedLineNameProperty = DependencyProperty.RegisterAttached(nameof(PresentedLineName), typeof(string), typeof(LinePresenter), new PropertyMetadata(null));
        public static readonly DependencyProperty PresentedLineIconSourceProperty = DependencyProperty.RegisterAttached(nameof(PresentedLineIconSource), typeof(ImageSource), typeof(LinePresenter), new PropertyMetadata(null));

        public string PresentedLineName
        {
            get => (string)GetValue(PresentedLineNameProperty);
            set => SetValue(PresentedLineNameProperty, value);
        }

        public ImageSource PresentedLineIconSource
        {
            get => (ImageSource)GetValue(PresentedLineIconSourceProperty);
            set => SetValue(PresentedLineIconSourceProperty, value);
        }

        public LinePresenter()
        {
            this.InitializeComponent();
        }
    }
}
