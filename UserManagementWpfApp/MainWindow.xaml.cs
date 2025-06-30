using BussinessObject;
using BussinessObjects;
using Services;
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
namespace UserManagementWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserService userService = new UserService();
        ProductService productService = new ProductService();

        public MainWindow()
        {
            InitializeComponent();
            productService.IntializeDataset();
            HienThiToanBoUsers();
        }

        private void HienThiToanBoUsers()
        {
            
            //List<Product> products = productService.GetProducts();
            lbUser.ItemsSource = productService.GetProducts();
        }

        private void lbUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count < 0)
            {
                return;
            }
            Product p = e.AddedItems[0] as Product;
            txtMa.Text = p.Id.ToString();
            txtTen.Text = p.Name.ToString();
            txtDonGia.Text = p.Price.ToString();
            txtSoLuong.Text = p.Quantity.ToString();
        }

        private void btnCapNhat_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.Id = int.Parse(txtMa.Text);
            p.Name = txtTen.Text;
            p.Price = int.Parse(txtDonGia.Text);
            p.Quantity = int.Parse(txtSoLuong.Text);

            productService.UpdateProduct(p);
            HienThiToanBoUsers();
        }
    }
}