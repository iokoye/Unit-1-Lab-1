using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Guess which will have more: heads or tails? ");
        string headsOrTailsGuess = Console.ReadLine();
        Console.WriteLine();
        Console.Write("How many times shall we flip a coin? ");
        int numberOfFlips = Convert.ToInt32(Console.ReadLine());
        int correctCount = 0;
        for(int i=0; i<numberOfFlips; i++){
            int result = new Random().Next(0, 2);
            if(result==0){
                Console.WriteLine("tails");
                if(result==0 & string.Equals(headsOrTailsGuess, "tails",  StringComparison.OrdinalIgnoreCase)){
                    correctCount++;
                }
            }
            if(result==1){
                Console.WriteLine("heads");
                if(result==1 & string.Equals(headsOrTailsGuess, "heads",  StringComparison.OrdinalIgnoreCase)){
                    correctCount++;
                }
            }
        }
       
        int percentageOfWins = (int)Math.Round((double)(100 * correctCount) / numberOfFlips);
        Console.WriteLine("Your guess, "+headsOrTailsGuess+", came up "+correctCount+" times(s).");
        Console.WriteLine("Thats "+percentageOfWins+"%");
    }
}
