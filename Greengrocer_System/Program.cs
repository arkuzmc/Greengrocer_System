using System.Collections;
using System.ComponentModel.Design;

namespace Greengrocer_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList productRecevied = new ArrayList();
            SortedList fruitAmount = new SortedList();
            SortedList vegetableAmount = new SortedList();

            while (true)
            {
                Console.WriteLine("Do you want to buy fruits or vegetables? ? (F/V)");
                string choose = Console.ReadLine();

                if (choose == "F")
                {
                    Console.WriteLine("Fruits");
                    string[] fruits = { "Apple", "Banana", "Armut", "Orange", "Strawberry", "Grape" };
                    foreach (var item in fruits)
                    {
                        Console.WriteLine(fruits);
                    }
                    Console.WriteLine("Which fruit did you choose ?");
                    string choosedfruit = Console.ReadLine();

                    Console.WriteLine("How many kilos do you want ?");
                    int kilo = Convert.ToInt32(Console.ReadLine());

                    if (fruitAmount.ContainsKey(choosedfruit))
                    {
                        fruitAmount[choosedfruit] = (int)fruitAmount[choosedfruit] + kilo;
                    }
                    else
                    {
                        fruitAmount.Add(choosedfruit, kilo);
                    }
                }
                else if (choose == "V")
                {
                    Console.WriteLine("Vegetables: ");
                    string[] vegetables = { "Tomato", "Cucumber", "Pepper", "Carrot", "Potato" };
                    foreach (var item in vegetables)
                    {
                        Console.WriteLine("Vegatables: ");
                    }

                    Console.WriteLine("Which vegetable did you choose ?");
                    string choosedvegatable = Console.ReadLine();

                    Console.WriteLine("How many kilos do you want ?");
                    int kilo = Convert.ToInt32(Console.ReadLine());


                    if (vegetableAmount.ContainsKey(choosedvegatable))
                    {
                        vegetableAmount[choosedvegatable] = (int)vegetableAmount[choosedvegatable] + kilo;
                    }
                    else
                    {
                        vegetableAmount.Add(choosedvegatable, kilo);
                    }
                }
                else
                {
                    Console.WriteLine("Wrong Process Please Try Again Later.");
                    continue;
                }
                Console.WriteLine("Do you want choose another thing ?");
                string cnt = Console.ReadLine();
                if (cnt != "e")
                {
                    break;
                }
            }


            Console.WriteLine("*****GREENGROCER PANEL*****");
            while (true)
            {
                Console.WriteLine("Please Enter the product you want to sell. (F/V)");
                string choose = Console.ReadLine();

                if (choose == "F")
                {
                    Console.WriteLine("Taken Fruits");
                    foreach (string fruit in fruitAmount.Keys)
                    {
                        Console.WriteLine($"{fruit}:{fruitAmount[fruit]}kg");

                    }


                    Console.WriteLine("Which fruit do you want to sell ?");
                    string choosedfruit = Console.ReadLine();


                    if (fruitAmount.ContainsKey(choosedfruit))
                    {
                        Console.WriteLine("How many kilos do you want to sell ?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if ((int)fruitAmount[choosedfruit] >= kilo)
                        {

                            fruitAmount[choosedfruit] = (int)fruitAmount[choosedfruit] - kilo;

                            Console.WriteLine($"{kilo} kg {choosedfruit} Selled.");

                        }
                        else
                        {
                            Console.WriteLine("Not Enough Product.");
                        }
                    }
                    else
                    {

                        Console.WriteLine("Product is not avaiable");

                    }
                }

                else if (choose == "V")
                {
                    Console.WriteLine("Taken Vegatables");
                    foreach (string vegatable in vegetableAmount.Keys)
                    {
                        Console.WriteLine($"{vegatable}:{vegetableAmount[vegatable]}KG");
                    }

                    Console.WriteLine("Which fruit do you want to sell ?");
                    string choosedvegatable = Console.ReadLine();

                    if (vegetableAmount.ContainsKey(choosedvegatable))
                    {
                        Console.WriteLine("How many kilos do you want to sell?");
                        int kilo = Convert.ToInt32(Console.ReadLine());

                        if ((int)vegetableAmount[choosedvegatable] >= kilo)
                        {
                            vegetableAmount[choosedvegatable] = (int)vegetableAmount[choosedvegatable] - kilo;
                            Console.WriteLine($"{kilo}KG{choosedvegatable} Selled");
                        }

                        else
                        {
                            Console.WriteLine("Not enough product");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Product is not avaiable");
                    }
                }

                else
                {
                    Console.WriteLine("Wrong process please try again later.");
                    continue;
                }


                Console.WriteLine("*****CUSTOMER PANEL*****");
                Console.WriteLine("Taken Product");
                foreach (string fruit in fruitAmount.Keys)
                {
                    Console.WriteLine($"{fruit}: {fruitAmount[fruit]} KG");
                }
                foreach (string vegatable in vegetableAmount.Keys)
                {
                    Console.WriteLine($"{vegatable}:{vegetableAmount[vegatable]} KG");
                }

                Console.WriteLine("Would you like to take another process (Y/N) ?: ");
                string cnt = Console.ReadLine();
                if (cnt.ToUpper() != "Y")
                {
                    break;
                }

            }
        }
    }
}
