using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Exam_Task.Interfaces
{
    public interface IProducts
    {
        string GetName();
        string GetBrand();
        double GetPrice();
        double CalculatePrice(DateTime date, double amount);
        double ProductsPrice(double amount);
        void CalculateDiscount(DiscountClass dsClass, int percents, double amount);
        void PrintInfo(double quantityOfProduct);
    }
}
