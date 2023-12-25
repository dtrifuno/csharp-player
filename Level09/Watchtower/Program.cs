Console.Write("Enemy's x coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enemy's y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

var direction = "";

if (y < 0) {
    direction = "south";
} else if (y > 0) {
    direction = "north";
}

if (x < 0) {
    direction += "west";
} else if (x > 0) {
    direction += "east";
}

if (x == 0 && y == 0) {
    Console.WriteLine("The enemy is here!");
} else {
    Console.WriteLine($"The enemy is to the {direction}!");
}