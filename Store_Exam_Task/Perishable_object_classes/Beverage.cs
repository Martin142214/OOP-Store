using Store_Exam_Task.Final_abstract_classes;
using Store_Exam_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Exam_Task
{
    public class Beverage : PerishableProduct
    {
        public Beverage(string name, string brand, double price, DateTime expiryDate)
        {
            Name = name;
            Brand = brand;
            Price = price;
            ExpirationDate = expiryDate;
            DiscountClass = new DiscountClass();
        }
    }
}
