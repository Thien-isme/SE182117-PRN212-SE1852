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

using TreeViewWPF.models;

namespace TreeViewWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Category> categories = SampleDataset.GenerateDataset(); 
        public MainWindow()
        {
            InitializeComponent();
            DisplayCategoriesAndProduct();
        }

        private void DisplayCategoriesAndProduct()
        {
            //Xoa du lieu cu di
            tvCategory.Items.Clear();
            //Tao goc cay (hoac tuy)
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hang Bình Dương";
            tvCategory.Items.Add(root);

            //nap du lieu moi
            foreach (KeyValuePair<int, Category> cate_kvp in categories)
            {
                Category cate = cate_kvp.Value;
                //tao category node
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = cate;
                //Dua category vao goc cay
                root.Items.Add(cate_node);
                // vòng lặp con để nạp sản phẩm cho từng danh mục
                foreach(KeyValuePair<int, Product> product_kvp in cate.Products)
                {
                    Product product = product_kvp.Value;
                    //tạo product node
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header = product;
                    // đưa product node vao cate node
                    cate_node.Items.Add(product_node);



                }



            }

        }
    }
}