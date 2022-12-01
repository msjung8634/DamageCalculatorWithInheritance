using System;
using System.Collections.Generic;
using System.Text;

namespace DamageCalculatorWithInheritance
{
     class ArrowDamage
     {
          const int BASE_DAMAGE = 3;
          const decimal BASE_MULTIPLIER = 0.35M;
          const decimal MAGIC_MULTIPLIER = 2.5M;
          const decimal FLAME_DAMAGE = 1.25M;

          public int Damage { get; private set; }

          private int roll;
          public int Roll
          {
               get { return roll; }
               set
               {
                    roll = value;
                    CalculateDamage();
               }
          }

          private bool magic;
          public bool Magic
          {
               get { return magic; }
               set
               {
                    magic = value;
                    CalculateDamage();
               }
          }

          private bool flaming;
          public bool Flaming
          {
               get { return flaming; }
               set
               {
                    flaming = value;
                    CalculateDamage();
               }
          }

          public void CalculateDamage()
          {
               // Damage Equation
               // #1. Roll * BASE_MULTIPLIER      # Always
               // #2. #1 * MAGIC_MULTIPLIER       # Magic only
               // #3. #2 + FLAME_DAMAGE           # Flaming only
               // #4. Math.Ceiling(#3)            # Always
               decimal baseDamage = Roll * BASE_MULTIPLIER;
               if (Magic) baseDamage *= MAGIC_MULTIPLIER;
               if (Flaming) Damage = (int)Math.Ceiling(baseDamage + FLAME_DAMAGE);
               else Damage = (int)Math.Ceiling(baseDamage);
          }

          public ArrowDamage(int startingRoll)
          {
               Roll = startingRoll;
               CalculateDamage();
          }
     }
}
