void Countdown(int n) {
    if (n <= 0) {
        return;
    }

    Console.WriteLine(n);
    Countdown(n - 1);
}

Countdown(10);