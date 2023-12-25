int AskForANumber(string text) {
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ExpectedDamage(int round) {
    if (round % 15 == 0) {
        return 10;
    } else if (round % 5 == 0 || round % 3 == 0) {
        return 3;
    } else {
        return 1;
    }
}

void PrintStatus(int round, int cityHealth, int manticoreHealth) {
    Console.WriteLine("======================================================");
    Console.WriteLine($"STATUS: Round {round,2}  City: {cityHealth,2}/15  Manticore: {manticoreHealth,2}/10");
}

int ConductRound(int round, int manticoreLocation) {
    int expectedDamage = ExpectedDamage(round);
    Console.WriteLine($"The cannon is expected to deal {expectedDamage} damage this round.");
    int range = AskForANumber("Enter desired cannon range: ");

    if (range < manticoreLocation) {
        Console.Write("That round ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("FELL SHORT");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" of the target.");
        return 0;
    } else if (range > manticoreLocation) {
        Console.Write("That round ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("OVERSHOT");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" the target.");
        return 0;
    } else {
        Console.Write("That round was a ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("DIRECT HIT");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("!");
        return expectedDamage;
    }

}

int manticoreLocation = AskForANumber("Player 1, how far away from the city do you want to station the Manticore? ");
Console.Clear();

int round = 1;
int manticoreHealth = 10;
int cityHealth = 15;
Console.WriteLine("Player 2, it is your turn.");
while (manticoreHealth > 0 && cityHealth > 0) {
    PrintStatus(round, cityHealth, manticoreHealth);
    manticoreHealth -= ConductRound(round, manticoreLocation);

    if (manticoreHealth > 0) {
        cityHealth -= 1;
    }
    round += 1;
}

Console.WriteLine();
if (cityHealth == 0) {
    Console.WriteLine("The city has been destroyed! The Manticore is victorious.");
} else {
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}