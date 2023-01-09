using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cardsPicked;
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            Console.WriteLine();

            if (int.TryParse(line, out int noOfCards))
            {
                cardsPicked = CardPicker.PickSomeCards(noOfCards);
                Console.WriteLine("You entered " + line + "cards to pick.");

                foreach (string card in cardsPicked)
                {
                    Console.WriteLine(card);
                }
               
            }
            else
            {
                Console.WriteLine("Invalid input. Run the program again and enter a number.");
            }

        }
    }
}
