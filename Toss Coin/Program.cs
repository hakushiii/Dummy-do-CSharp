Random coin = new Random();
string flip = coin.Next(0, 2) > 0 ? "Heads" : "Tails";
Console.WriteLine($"Coin Flipped: {flip}");
