using System;

namespace DamageCalculatorWithInheritance
{
     class Program
     {
          static Random random = new Random();

          static void Main(string[] args)
          {
               ArrowDamage arrowDamage = new ArrowDamage(RollDice(1));
               SwordDamage swordDamage = new SwordDamage(RollDice(3));

               while (true)
               {
                    Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit : ");
                    char input = Console.ReadKey(false).KeyChar;
                    if (input != '0' && input != '1' && input != '2' && input != '3') return;

                    Console.WriteLine("\nS for word, A for arrow, anything else to quit: ");
                    char weaponKey = char.ToUpper(Console.ReadKey(false).KeyChar);

                    switch (weaponKey)
                    {
                         case 'S':
                              swordDamage.Roll = RollDice(3);
                              swordDamage.Magic = (input == '1' || input == '3');
                              swordDamage.Flaming = (input == '2' || input == '3');
                              Console.WriteLine($"\nRolled {swordDamage.Roll} for {swordDamage.Damage} HP");
                              break;
                         case 'A':
                              arrowDamage.Roll = RollDice(1);
                              arrowDamage.Magic = (input == '1' || input == '3');
                              arrowDamage.Flaming = (input == '2' || input == '3');
                              Console.WriteLine($"\nRolled {arrowDamage.Roll} for {arrowDamage.Damage} HP");
                              break;
                         default:
                              break;
                    }
               }

               int RollDice(int numberOfRolls)
               {
                    int total = 0;
                    for (int i = 0; i < numberOfRolls; i++)
                         total += random.Next(1, 7);
                    return total;
               }
          }
     }
}
