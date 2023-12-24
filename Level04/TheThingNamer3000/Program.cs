Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // Item type
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); /* Adjective describing item */
string c = "of Doom"; /* Suffix "of Doom" */
string d = "3000"; /* Model number */
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");