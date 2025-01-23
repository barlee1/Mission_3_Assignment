// See https://aka.ms/new-console-template for more information

using FoodItems;
    
//select one of the following options
internal class Program
{
    public static void Main(string[] args)
    {
        List<FoodItem> foodItems = new List<FoodItem>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Welcome to the Food Donation System. Please choose an option:");
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Delete an item");
            Console.WriteLine("3. View list of items");
            Console.WriteLine("4. Exit the Program");
            string choice = Console.ReadLine();

        // Allow the user to add in a food item, and then an object is created and stored in a list
            if (choice == "1")
            {
                Console.WriteLine("Please enter the food item's name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter the food item's category: ");
                string category = Console.ReadLine();
                Console.WriteLine("Please enter the food item's quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the food item's expiration date (mm/dd/yyyy): ");
                string expirationDate = Console.ReadLine();

                FoodItem fi = new FoodItem(name, category, quantity, expirationDate);
                foodItems.Add(fi);
                
                Console.WriteLine("Item added successfully!");
            }

            // showing a list of items and allowing the user to delete one based off of a number
            else if (choice == "2")
            {
                if (foodItems.Count == 0)
                {
                    Console.WriteLine("No items available to delete.");
                }
                else
                {
                    Console.WriteLine("Current items: ");
                    for (int i = 0; i < foodItems.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {foodItems[i].Name}");
                    }
                    Console.WriteLine("Enter the number of the item to delete: ");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    if (index >= 0 && index < foodItems.Count)
                    {
                        Console.WriteLine($"Item '{foodItems[index].Name}' deleted.");
                        foodItems.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                }
                
            }
            // print list of current food items
            else if (choice == "3")
            {
                if (foodItems.Count == 0)
                {
                    Console.WriteLine("No items in list.");
                }
                else
                {
                    Console.WriteLine("Current items: ");
                    for (int i = 0; i < foodItems.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}: {foodItems[i].Name}");
                    }
                }
            }

            // exit the program
            else if (choice == "4")
            {
                Console.WriteLine("Thank you for using this program!");
                running = false;
            }

            //error handling if an invalid number is chosen as an option
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine();
           
            }
        }
}
