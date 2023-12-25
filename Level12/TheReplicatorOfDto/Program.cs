var originals = new int[5];
for (int i = 0; i < 5; i++) {
    Console.Write($"Enter the {i+1}th item: ");
    var value = Convert.ToInt32(Console.ReadLine());
    originals[i] = value;
}

var copied = new int[5];
for (int i = 0; i < 5; i++) {
    copied[i] = originals[i];
}

Console.Write($"Original: [");
for (int i = 0; i < 5; i++) {
    if (i != 0) {
        Console.Write(", ");
    }
    Console.Write(originals[i]);
}
Console.WriteLine("]");

Console.Write($"Copied: [");
for (int i = 0; i < 5; i++) {
    if (i != 0) {
        Console.Write(", ");
    }
    Console.Write(copied[i]);
}
Console.WriteLine("]");