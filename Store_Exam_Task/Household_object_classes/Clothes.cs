using Store_Exam_Task.Abstract_classes;
using Store_Exam_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Exam_Task
{
    public class Clothes : BaseAttributes
    {
        private string Size { get; set; }
        private string Color { get; set; }

        public Clothes(string name, string brand, double price, string size, string color)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Size = size;
            Color = color;
            DiscountClass = new DiscountClass();
        }

        public string GetSize() => this.Size;

        public string GetColor() => this.Color;


        public override double CalculatePrice(DateTime date, double amount)
        {
            int day = (int)date.DayOfWeek;

            if (day >= 1 && day <= 5)
            {
                CalculateDiscount(DiscountClass, 10, amount);
            }
            double price = ProductsPrice(amount);

            return price;
        }
        public override void PrintInfo(double quantityOfProduct)
        {
            Console.WriteLine($"{this.GetName()} {this.GetBrand()} {this.GetSize()} {this.GetColor()}");
            Console.WriteLine($"{quantityOfProduct} x ${this.GetPrice().ToString("0.00")} = ${(quantityOfProduct * this.GetPrice()).ToString("0.00")}");
            if (this.DiscountClass.AnyDiscount)
            {
                Console.WriteLine($"#discount {this.DiscountClass.DiscountInPercents}% : -${this.DiscountClass.DiscountInDollars.ToString("0.00")}");
            }
        }
    }
}
