using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Exam_Task
{
    public class Cashier
    {
        public void PrintReceipt(Cart cart, DateTime dateOfPurchase)
        {
            double applesKilograms = 2.45;
            int bottlesOfMilk = 3;
            int numberOfClothes = 2;
            int numberOfAppliances = 1;

            Console.WriteLine("Cart:");
            Console.WriteLine($"{cart.Food.GetName()} x {applesKilograms} kg");
            Console.WriteLine($"{cart.Beverages.GetName()} x {bottlesOfMilk} bottles");
            Console.WriteLine($"{cart.Clothes.GetName()} x {numberOfClothes}");
            Console.WriteLine($"{cart.Appliances.GetName()} x {numberOfAppliances}");
            Console.WriteLine("Date and time of purchase:");
            Console.WriteLine(dateOfPurchase);
            Console.WriteLine();

            Console.WriteLine($"Date: {dateOfPurchase}");

            Console.WriteLine("---Products---");
            var foodPrice = cart.Food.CalculatePrice(dateOfPurchase, applesKilograms);
            cart.Food.PrintInfo(applesKilograms);

            Console.WriteLine();

            var beveragesPrice = cart.Beverages.CalculatePrice(dateOfPurchase, bottlesOfMilk);
            cart.Beverages.PrintInfo(bottlesOfMilk);

            Console.WriteLine();

            var clothesPrice = cart.Clothes.CalculatePrice(dateOfPurchase, numberOfClothes);
            cart.Clothes.PrintInfo(numberOfClothes);

            Console.WriteLine();

            var appliancesPrice = cart.Appliances.CalculatePrice(dateOfPurchase, numberOfAppliances);
            cart.Appliances.PrintInfo(numberOfAppliances);

            Console.WriteLine();

            var subtotal = foodPrice + beveragesPrice + clothesPrice + appliancesPrice;
            Console.WriteLine($"SUBTOTAL: ${subtotal.ToString("0.00")}");

            var discount = cart.Food.DiscountClass.DiscountInDollars + cart.Beverages.DiscountClass.DiscountInDollars + cart.Clothes.DiscountClass.DiscountInDollars + cart.Appliances.DiscountClass.DiscountInDollars;
            Console.WriteLine($"DISCOUNT: -${discount.ToString("0.00")}");

            Console.WriteLine($"TOTAL: ${(subtotal - discount).ToString("0.00")}");
        }
    }
}
