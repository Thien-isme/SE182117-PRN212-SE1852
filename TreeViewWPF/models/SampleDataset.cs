using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewWPF.models
{
    public class SampleDataset
    {
        public static Dictionary<int, Category> GenerateDataset()
        {
            Dictionary<int, Category> categories = new Dictionary<int, Category>();
            Category c1 = new Category();
            c1.Id = 1;
            c1.Name = "Laptop";

            Category c2 = new Category();
            c2.Id = 2;
            c2.Name = "Tablet";

            Category c3 = new Category();
            c3.Id = 3;
            c3.Name = "Desktop";
            categories.Add(c1.Id, c1);
            categories.Add(c2.Id, c2);
            categories.Add(c3.Id, c3);

            //Tao san pham cho cac danh muc
            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "Laptop Dell";
            p1.Quantity = 10;
            p1.Price = 1200.50;

            Product p2 = new Product();
            p2.Id = 2;
            p2.Name = "iPhone 15";
            p2.Quantity = 25;
            p2.Price = 799.99;

            Product p3 = new Product();
            p3.Id = 3;
            p3.Name = "iPad Air";
            p3.Quantity = 15;
            p3.Price = 450.00;

            Product p4 = new Product();
            p4.Id = 4;
            p4.Name = "Desktop HP";
            p4.Quantity = 8;
            p4.Price = 1500.75;

            Product p5 = new Product();
            p5.Id = 5;
            p5.Name = "Mouse Logitech";
            p5.Quantity = 50;
            p5.Price = 29.95;

            Product p6 = new Product();
            p6.Id = 6;
            p6.Name = "Headphones Sony";
            p6.Quantity = 30;
            p6.Price = 89.50;

            Product p7 = new Product();
            p7.Id = 7;
            p7.Name = "Keyboard Razer";
            p7.Quantity = 20;
            p7.Price = 59.99;

            Product p8 = new Product();
            p8.Id = 8;
            p8.Name = "Monitor Samsung";
            p8.Quantity = 12;
            p8.Price = 250.00;

            Product p9 = new Product();
            p9.Id = 9;
            p9.Name = "Printer Canon";
            p9.Quantity = 5;
            p9.Price = 199.95;

            Product p10 = new Product();
            p10.Id = 10;
            p10.Name = "Speaker JBL";
            p10.Quantity = 18;
            p10.Price = 79.99;

            Product p11 = new Product();
            p11.Id = 11;
            p11.Name = "Camera Nikon";
            p11.Quantity = 7;
            p11.Price = 499.00;

            Product p12 = new Product();
            p12.Id = 12;
            p12.Name = "Router TP-Link";
            p12.Quantity = 15;
            p12.Price = 89.95;

            Product p13 = new Product();
            p13.Id = 13;
            p13.Name = "Hard Drive Seagate";
            p13.Quantity = 10;
            p13.Price = 129.50;

            Product p14 = new Product();
            p14.Id = 14;
            p14.Name = "USB SanDisk";
            p14.Quantity = 35;
            p14.Price = 19.99;

            Product p15 = new Product();
            p15.Id = 15;
            p15.Name = "Tablet Samsung";
            p15.Quantity = 12;
            p15.Price = 399.00;

            c1.Products.Add(p1.Id, p1);
            c1.Products.Add(p2.Id, p2);
            c1.Products.Add(p3.Id, p3);
            c1.Products.Add(p4.Id, p4);
            c1.Products.Add(p5.Id, p5);

            c2.Products.Add(p6.Id, p6);
            c2.Products.Add(p7.Id, p7);
            c2.Products.Add(p8.Id, p8);
            c2.Products.Add(p9.Id, p9);
            c2.Products.Add(p10.Id, p10);

            c3.Products.Add(p11.Id, p11);
            c3.Products.Add(p12.Id, p12);
            c3.Products.Add(p13.Id, p13);
            c3.Products.Add(p14.Id, p14);
            c3.Products.Add(p15.Id, p15);

            return categories;
        }

    }
}
