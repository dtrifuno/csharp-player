int AskForANumber(string text) {
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = AskForANumber("What's the current number? ");
if (number % 2 == 0) {
    Console.WriteLine("Tick");
} else {
    Console.WriteLine("Tock");
}