using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace DamageCalculatorWithInheritance
{
     class SwordDamage
     {
          const int BASE_DAMAGE = 3;
          const int FLAME_DAMAGE = 2;

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
               decimal magicMultiplier = 1M;
               if (Magic) magicMultiplier = 1.7M;

               Damage = BASE_DAMAGE;
               Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE;
               if (Flaming) Damage += FLAME_DAMAGE;
          }

          public SwordDamage(int startingRoll)
          {
               Roll = startingRoll;
               CalculateDamage();
          }
     }
}
