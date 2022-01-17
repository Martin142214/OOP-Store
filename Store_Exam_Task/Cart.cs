using System;
using System.Collections.Generic;
using System.Text;

namespace Store_Exam_Task
{
    public class Cart
    {
        public Food Food { get; set; }
        public Beverage Beverages { get; set; }
        public Clothes Clothes { get; set; }
        public Appliance Appliances { get; set; }

        public Cart(Food food, Beverage beverages, Clothes clothes, Appliance appliances)
        {
            Food = food;
            Beverages = beverages;
            Clothes = clothes;
            Appliances = appliances;
        }
    }
}
