Console.WriteLine("How many eggs did you gather today?");
int eggs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Each sister gets " + eggs / 4 + " eggs, and there are " + eggs % 4 + " eggs left over for the duckbear.");