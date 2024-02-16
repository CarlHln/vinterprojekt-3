using System;

public class Fighter
{
  //fighter properties 
  public string name;
  public int hp = 100;
  public Weapon weapon;

//block chance
  public double blockchance = 0.2;

//attack method 
  public void Attack(Fighter target)
  {
    //attack info
    Console.WriteLine($"{name} attacked {target.name} with a {weapon.name}");
    //generate a random value for block chance
    double randomValue = new Random().NextDouble();

//check if attack is blocked
    if(randomValue < blockchance){
      Console.WriteLine($"{target.name} parried the attack!");
    }
    //if not blocked, attack target with intended damage
    else {
      int damage = weapon.GetDamage();
      target.hp -= damage;
      //check for a critical hit
      if(damage > 16){
        Console.WriteLine($"{name} lands a critical!");
      }
//display damage information
      Console.WriteLine($"{target.name} takes {damage} damage!");
    }
//check if target is dead 
    if(target.hp <= 0){
      Console.WriteLine($"{target.name} has fallen!");
    }

  }
}