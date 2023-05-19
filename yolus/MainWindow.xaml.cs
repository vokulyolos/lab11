using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace yolus
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void cbFonts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ComboBox).SelectedItem as ComboBoxItem;
            tbPreview.FontFamily = new FontFamily(item.Content.ToString());
        }

        private void cbSize_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ComboBox).SelectedItem as ComboBoxItem;
            tbPreview.FontSize = int.Parse(item.Content.ToString());
        }

        private void cbBold_CheckedChanged(object sender, RoutedEventArgs e)
        {
            ApplyFontStyle();
        }

        private void cbUnderline_CheckedChanged(object sender, RoutedEventArgs e)
        {
            ApplyFontStyle();
        }

        private void cbItalic_CheckedChanged(object sender, RoutedEventArgs e)
        {
            ApplyFontStyle();
        }

        private void ApplyFontStyle()
        {
            tbPreview.FontWeight = (cbBold.IsChecked == true) ? FontWeights.Bold : FontWeights.Normal;
            tbPreview.TextDecorations = (cbUnderline.IsChecked == true) ? TextDecorations.Underline : null;
            tbPreview.FontStyle = (cbItalic.IsChecked == true) ? FontStyles.Italic : FontStyles.Normal;
        }
    }
}
