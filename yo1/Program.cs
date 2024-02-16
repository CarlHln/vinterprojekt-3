﻿using System;

Fighter hero = new Fighter();
hero.name = "Carl";
hero.weapon = new Weapon();
hero.weapon.name = "Longsword";

Fighter villain = new Fighter();
villain.name = "Namith";
villain.weapon = new Weapon();
villain.weapon.name = "Stick";


Random generator = new Random();

while (hero.hp > 0 && villain.hp > 0)
{
  //display battle info 
  Console.WriteLine("/////////// New Round ///////////");
  Console.WriteLine($"{hero.name}: {hero.hp} hp || {villain.name}: {villain.hp} hp");
  //turns attacking
  hero.Attack(villain);
  villain.Attack(hero);

//continue info 
  Console.WriteLine("Press a button to continue.");
  Console.ReadKey();
}
//show that the battle is over
Console.WriteLine("/////////// The Fight Is Over ///////////");

//check outcome 
if (hero.hp <= 0 && villain.hp <= 0)
{
  Console.WriteLine("Both champs have fallen.");
}
else if (hero.hp == 0)
{
  Console.WriteLine($"{villain.name} Wins!");
}
else
{
  Console.WriteLine($"{hero.name} Wins!");
}
//end info
Console.WriteLine("Press a button to end.");
Console.ReadKey();