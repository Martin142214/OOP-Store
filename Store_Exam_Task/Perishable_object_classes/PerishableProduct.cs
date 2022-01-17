using Store_Exam_Task.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Exam_Task.Final_abstract_classes
{
    public class PerishableProduct : BaseAttributes
    {
        protected DateTime ExpirationDate { get; set; }
        public override double CalculatePrice(DateTime date, double amount)
        {
            if (ExpirationDate.Day - date.Day >= 1 && ExpirationDate.Day - date.Day <= 5)
            {
                CalculateDiscount(DiscountClass, 10, amount);
            }
            else if (ExpirationDate.Day == date.Day)
            {
                CalculateDiscount(DiscountClass, 50, amount);
            }
            double price = ProductsPrice(amount);

            return price;
        }

        public override void PrintInfo(double quantityOfProduct)
        {
            Console.WriteLine($"{this.GetName()} - {this.GetBrand()}");
            Console.WriteLine($"{quantityOfProduct} x ${this.GetPrice().ToString("0.00")} = ${(quantityOfProduct * this.GetPrice()).ToString("0.00")}");
            if (this.DiscountClass.AnyDiscount)
            {
                Console.WriteLine($"#discount {this.DiscountClass.DiscountInPercents}% : -${this.DiscountClass.DiscountInDollars.ToString("0.00")}");
            }
        }
    }
}
