using System;
using Weapon;

namespace StaticMembers
{
  class WeaponTester
  {
    static void Main(string[] args)
    {
      Weapon w1 = new Weapon("Dagger");
      w1.PrintWeapon();
    }
  }
}