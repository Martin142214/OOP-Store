using System;
using System.Collections.Generic;

namespace Store_Exam_Task
{
    static class Program
    {
        static void Main(string[] args)
        {
            DateTime dateOfPurchase = new DateTime(2021, 6, 14, 12, 34, 56);

            Food food = new Food("apple", "BrandA", 1.50, new DateTime(2021, 6, 14));

            Beverage beverage = new Beverage("milk", "BrandM", 0.99, new DateTime(2022, 2, 2));

            Clothes clothes = new Clothes("T-shirt", "BrandT", 15.99, "M", "violet");

            Appliance appliance = new Appliance("laptop", "BrandL", 2345, "ModelL", new DateTime(2021, 3, 3), 1.125);

            Cart cart = new Cart(food, beverage, clothes, appliance);

            Cashier cashier = new Cashier();
            cashier.PrintReceipt(cart, dateOfPurchase);
        }
    }
}
