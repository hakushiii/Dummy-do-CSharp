string pangram = "The quick brown fox jumps over the lazy dog";
string reversedPangram = "";

string[] pangramItems = pangram.Split(" ");

foreach (string item in pangramItems){
    char[] itemArray = item.ToCharArray();
    Array.Reverse(itemArray);

    string reversedItem = String.Join("", itemArray);
    reversedPangram = reversedPangram + reversedItem + " ";
}

Console.WriteLine(reversedPangram);