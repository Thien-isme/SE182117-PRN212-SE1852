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

namespace Bai1
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

        private void btnTong_Click(object sender, RoutedEventArgs e)
        {
            int heSoA = int.Parse(txtHeSoA.Text);
            int heSoB = int.Parse(txtHeSoB.Text);
            int tinhTong = heSoA + heSoB;
            lblKetQua.Content = tinhTong;
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}