using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadioButtonControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnGui_Click(object sender, RoutedEventArgs e)
        {
            string binhChon = string.Empty;
            if (radRatTot.IsChecked == true)
            {
                binhChon = radRatTot.Content+"";
            }
            else if (radTot.IsChecked == true)
            {
                binhChon = radTot.Content + "";
            }
            else if (radKhongTot.IsChecked == true)
            {
                binhChon = radKhongTot.Content + "";
            }
            string gioiTinh = string.Empty;
            if (radNam.IsChecked == true)
            {
                gioiTinh = radNam.Content + "";
            }
            else if (radNu.IsChecked == true)
            {
                gioiTinh = radNu.Content + "";
            }
            string infor = "Bạn bình chọn Hệ Thống = " + binhChon + Environment.NewLine +
                         "Giới tính của bạn = " + gioiTinh;
            MessageBoxResult ret;
            ret = MessageBox.Show(infor, "Mời bạn xác nhận", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (ret == MessageBoxResult.Yes)
            {
                MessageBox.Show("Cảm ơn bạn đã bình chọn");
            }
        }
        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}