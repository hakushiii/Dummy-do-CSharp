string? input;

Console.WriteLine("Insert number between 5 and 10: ");
do {
    input = Console.ReadLine();
    if (input != null){
        try{
            int inputNumber = Convert.ToInt32(input);
            if (inputNumber >=5 && inputNumber <=10){
                Console.WriteLine($"Input Value ({inputNumber}) has been acknowledged");
            }
            else{
                Console.WriteLine($"You entered ({inputNumber}), a number not in range.");
            }
        }
        catch{
            Console.WriteLine("Invalid Number");
        }
    }
    
} while (input == null);