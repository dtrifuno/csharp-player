Console.WriteLine("How many provinces does His Highness have?");
int provinces = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And duchies?");
int duchies = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("And estates?");
int estates = Convert.ToInt32(Console.ReadLine());

int score = 6 * provinces + 3 * duchies + estates;
Console.WriteLine("His Highness's score is " + score + ".");