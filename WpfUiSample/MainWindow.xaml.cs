using System.Windows;
using System.Windows.Controls;

namespace WpfUiSample
{
    public partial class MainWindow : Wpf.Ui.Controls.FluentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BrightnessSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ValueText.Text = $"亮度: {(int)e.NewValue}";
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this,
                $"设置亮度为 {(int)BrightnessSlider.Value}",
                "WPF-UI 示例",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }
    }
}