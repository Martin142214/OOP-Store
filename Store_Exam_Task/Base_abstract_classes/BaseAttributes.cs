using Store_Exam_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Exam_Task.Abstract_classes
{
    public abstract class BaseAttributes : IProducts
    {
        protected string Name { get; set; }
        protected string Brand { get; set; }
        protected double Price { get; set; }
        public DiscountClass DiscountClass { get; set; }

        public string GetName() => this.Name;

        public string GetBrand() => this.Brand;

        public double GetPrice() => this.Price;

        public abstract double CalculatePrice(DateTime date, double amount);

        public abstract void PrintInfo(double quantityOfProduct);

        public double ProductsPrice(double amount)
        {
            var res = this.GetPrice() * amount;
            return res;
        }

        public void CalculateDiscount(DiscountClass dsClass, int percents, double amount)
        {
            dsClass.DiscountInPercents = percents;
            dsClass.DiscountInDollars = ((this.GetPrice() * amount) * percents) / 100;
            dsClass.AnyDiscount = true;
        }

    }
}
