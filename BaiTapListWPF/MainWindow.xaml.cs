﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaiTapListWPF
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
        List<int> dsDuLieu = new List<int>();

        private void HienThiDanhSach()
        {
            lstDuLieu.Items.Clear();

            for (int i = 0; i < dsDuLieu.Count; i++)
            {
                int x = dsDuLieu[i];
                lstDuLieu.Items.Add(x);
            }
        }
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsDuLieu.Add(x);
            HienThiDanhSach();
            txtGiaTri.Text = "";
        }
        

        private void btnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTriChen.Text);
            int vt = int.Parse(txtGiaTriChen.Text);
            dsDuLieu.Insert(vt, x);
            HienThiDanhSach();
            txtGiaTri.Text = "";
            txtViTriChen.Text = "";
        }

        private void btnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienThiDanhSach() ;
        }

        private void btnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienThiDanhSach();
        }

        private void btnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if(lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần từ mới xoá được", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            dsDuLieu.Remove(lstDuLieu.SelectedIndex);
            HienThiDanhSach();

        }

        private void btnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần từ mới xoá được", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }

            while (lstDuLieu.SelectedItems.Count > 0)
            {
                int data = lstDuLieu.SelectedIndex;
                dsDuLieu.Remove(data);
                lstDuLieu.Items.Remove(data);
            }
            HienThiDanhSach() ;

        }

        private void btnXoaToanBoPhanTu_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienThiDanhSach();
        }
    }
}