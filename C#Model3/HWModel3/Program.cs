using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HWModel3
{
    class Program
    {
        static void Main(string[] args)
        {        
            // Here we create a new Hashtable 'prices' using the Add function in order to add a drink and the price.
            // This gives us the information needed to do a LINQ expression later.
            Hashtable prices = new Hashtable();
            prices.Add("Café au Lait", 1.99M);
            prices.Add("Caffe Americano", 1.89M);
            prices.Add("Café Mocha", 2.99M);
            prices.Add("Cappuccino", 2.49M);
            prices.Add("Espresso", 1.49M);
            prices.Add("Espresso Romano", 1.59M);
            prices.Add("English Tea", 1.69M);
            prices.Add("Juice", 2.89M);

            // Using a LINQ expression we can scan through the hashtable and select all the drinks that have a price less then $2.00 and put them in order. 
            //(Prior to learning of LINQ expressions I might have tried to do this using a foreach loop with if statements.)
            var bargains =
               from string drink in prices.Keys
               where (Decimal)prices[drink] < 2.00M
               orderby prices[drink] ascending
               select drink;

            // Display the results of the LINQ expression.
            foreach (string bargain in bargains)
            {
                Console.WriteLine(bargain);
            }
            Console.ReadLine();
        }
    }
    //Setting up an event handling situation where deducts from the current stock and triggers if the amount of coffee in stock reachs its minimum.
    class Store
    {
        public struct Coffee
        {
            // Here we are declaring the event and the delegate. The delegate allows other code to gain some access to your event.
            public EventArgs e;
            public delegate void OutOfBeansHandler(Coffee coffee, EventArgs args);
            public event OutOfBeansHandler OutOfBeans;
            int currentStockLevel;
            int minimumStockLevel;

            public void MakeCoffee()
            {
                // Reduce the stock level after making coffee.
                currentStockLevel--;
                // If the stock level drops below the minimum, raise the event.
                if (currentStockLevel < minimumStockLevel)
                {
                    // Check whether the event is null.
                    if (OutOfBeans != null)
                    {
                        // Raise the event.
                        OutOfBeans(this, e);
                    }
                }
            }
        }
    }
}
