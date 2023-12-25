ChestState state = ChestState.Locked;
while (true) {
    PrintState(state);
    Console.Write(" What do you want to do? ");
    string action = Console.ReadLine().ToLower();
    if (state == ChestState.Open && action == "close") {
        state = ChestState.Closed;
    } else if (state == ChestState.Locked && action == "unlock") {
        state = ChestState.Closed;
    } else if (state == ChestState.Closed && action == "lock") {
        state = ChestState.Locked;
    } else if (state == ChestState.Closed && action == "open") {
        state = ChestState.Open;
    }
}

void PrintState(ChestState state) {
    string stateDescription = state switch {
        ChestState.Open => "open",
        ChestState.Closed => "closed",
        ChestState.Locked => "locked"
    };
    Console.Write($"The chest is {stateDescription}.");
}

enum ChestState
{
    Open,
    Closed,
    Locked,
    
}

