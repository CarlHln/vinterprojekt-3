using System;

public class Weapon
{
  //weapon properties
  public string name;
  private Random generator;

  public Weapon()
  {
    //random number generator for damage
    generator = new Random();
  }

//method for attack value
  public int GetDamage()
  {
    //generate random damage value between 1-20
    return generator.Next(1, 20);
  }

}