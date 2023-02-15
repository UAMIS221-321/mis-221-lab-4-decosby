Random rnd = new Random();
while (true){
    Console.WriteLine("Enter 1 to display full triangle");
    Console.WriteLine("Enter 2 to display partial triangle");
    Console.WriteLine("Enter 3 to exit");

    int input = int.Parse(Console.ReadLine());
    if (input == 1){
        for (int i = 1; i <= 4; i++){
            for (int j = 1; j <= i; j++){
                Console.Write("O ");
            }
            Console.WriteLine();
        }
    }else if (input == 2){
        for (int i = 1; i <= 4; i++){
            for (int j = 1; j <= i; j++){
                int num = rnd.Next(2);
                if (num == 0){
                    Console.Write("O ");
                }else{
                    Console.Write("  ");
                }
            }
            Console.WriteLine();
        }
    }else if (input == 3){
        break;
    }else{
        Console.WriteLine("Invalid input. Enter 1, 2, or 3.");
    }
}

    