
Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.Write("What's your name? ");
string name = Console.ReadLine();
Console.Write("What number do you want to see the price of? ");
int choice = Convert.ToInt32(Console.ReadLine());

string itemName = choice switch
{
    1 => "rope",
    2 => "torches",
    3 => "climbing equipment",
    4 => "clean water",
    5 => "machete",
    6 => "canoe",
    7 => "food supplies",
};

int price = choice switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1
};

if (name == "Darko") {
    double discountedPrice = 0.5 * price;
    Console.WriteLine($"Just for you {name}, {itemName} cost {discountedPrice} gold.");
} else {
    Console.WriteLine($"{name}, {itemName} cost {price} gold.");
}