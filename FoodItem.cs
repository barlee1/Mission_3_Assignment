// Add Food item class
// I'm thinking we create the object here
using System.ComponentModel;

namespace FoodItems
{
    
public class FoodItem
{
    // Properties
    public string Name { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }
    public string ExpirationDate { get; set; }

    // Constructor
    public FoodItem(string name, string category, int quantity, string expirationDate)
    {
        Name = name;
        Category = category;
        Quantity = quantity;
        ExpirationDate = expirationDate;
    }
}
}
