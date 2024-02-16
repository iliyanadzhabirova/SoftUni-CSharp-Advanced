using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {
    
        public int  ButtonCapacity { get; set; }
        public  List<Drink> Drinks { get; set; }
        public int GetCount
        {
            get
            {
                return Drinks.Count;
            }
        }

        public VendingMachine(int buttonCapacity)
        {
            ButtonCapacity = buttonCapacity;
            Drinks = new();
           
        }

        public void AddDrink(Drink drink)
        {
            if (ButtonCapacity > GetCount)
            {
                if (!Drinks.Contains(drink))
                {
                    Drinks.Add(drink);
                }
            }
        }
        public bool RemoveDrink(string name)
        {
   
            return Drinks.Remove(Drinks.FirstOrDefault(i => i.Name == name));
        }
        public Drink GetLongest()
        {
            return Drinks.OrderByDescending(d => d.Volume).First();
        }

        public Drink GetCheapest()
        {
            return Drinks.OrderBy(d => d.Price).First();
        }

        public string BuyDrink(string name)
        {
            return Drinks.Find(x => x.Name == name).ToString();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Report:");
            foreach (Drink drink in Drinks)
            {
                sb.AppendLine(drink.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
