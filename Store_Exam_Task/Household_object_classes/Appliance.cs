using Store_Exam_Task.Abstract_classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Exam_Task
{
    public class Appliance : BaseAttributes
    {
        private string Model { get; set; }
        private DateTime ProductionDate { get; set; }
        private double Weight { get; set; }

        public Appliance(string name, string brand, double price, string model, DateTime productionDate, double weight)
        {
            Name = name;
            Brand = brand;
            Price = price;
            Model = model;
            ProductionDate = productionDate;
            Weight = weight;
            DiscountClass = new DiscountClass();
        }

        public string GetModel() => this.Model;

        public double GetWeight() => this.Weight;

        public DateTime GetProductionDate() => this.ProductionDate;

        public override double CalculatePrice(DateTime date, double amount)
        {
            double price = this.Price;
            int day = (int)date.DayOfWeek;

            if (day >=6 && price > 999)
            {
                CalculateDiscount(DiscountClass, 5, amount);
            }

            price = ProductsPrice(amount);

            return price;
        }
        public override void PrintInfo(double quantityOfProduct)
        {
            Console.WriteLine($"{this.GetName()} {this.GetBrand()} {this.GetModel()}");
            Console.WriteLine($"{quantityOfProduct} x ${this.GetPrice()} = ${quantityOfProduct * this.GetPrice()}");
            if (this.DiscountClass.AnyDiscount)
            {
                Console.WriteLine($"#discount {this.DiscountClass.DiscountInPercents}% : -${this.DiscountClass.DiscountInDollars}");
            }
        }
    }
}
