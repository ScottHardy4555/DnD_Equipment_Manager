using System;
using Item.cs;

namespace EquipmentManager
{
    class Weapon : Item {

    }
}

// switch (name)
//         {
//             case "Club":
//                 Cost = .1;
//                 dmg = "1d4";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 2;
//                 string[] Properties = {"Light"};
//                 isSimple = true;
//                 break;
//             case "Dagger":
//                 Cost = 2;
//                 dmg = "1d4";
//                 Dmg_Type = "Piercing";
//                 Weight = 1;
//                 string[] Properties = {"Finesse", "Light", "Thrown", "Range: 20/60"};
//                 isSimple = true;
//                 break;
//             case "Greatclub":
//                 Cost = .2;
//                 dmg = "1d8";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 10;
//                 string[] Properties = {"Two-handed"};
//                 isSimple = true;
//                 break;
//             case "Handaxe":
//                 Cost = 5;
//                 dmg = "1d6";
//                 Dmg_Type = "Slashing";
//                 Weight = 2;
//                 string[] Properties = {"Light", "Thrown", "Range 20/60"};
//                 isSimple = true;
//                 break;
//             case "Javelin":
//                 Cost = .5;
//                 dmg = "1d6";
//                 Dmg_Type = "Piercing";
//                 Weight = 2;
//                 string[] Properties = {"Thrown", "Range 30/120"};
//                 isSimple = true;
//                 break;
//             case "Light Hammer":
//                 Cost = 2;
//                 dmg = "1d4";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 2;
//                 string[] Properties = {"Light", "Thrown", "Range 20/60"};
//                 isSimple = true;
//                 break;
//             case "Mace":
//                 Cost = 5;
//                 dmg = "1d6";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 4;
//                 string[] Properties = {"-"};
//                 isSimple = true;
//                 break;
//             case "Quarterstaff":
//                 Cost = .2;
//                 dmg = "1d6";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 4;
//                 string[] Properties = {"Versatile", "1d8"};
//                 isSimple = true;
//                 break;
//             case "Sickle":
//                 Cost = 1;
//                 dmg = "1d4";
//                 Dmg_Type = "Slashing";
//                 Weight = 2;
//                 string[] Properties = {"Light"};
//                 isSimple = true;
//                 break;
//             case "Light Crossbow":
//                 Cost = 25;
//                 dmg = "1d8";
//                 Dmg_Type = "Piercing";
//                 Weight = 5;
//                 string[] Properties = {"Ammunition", "Range 80/320", "Loading", "Two-Handed"};
//                 isSimple = true;
//                 break;
//             case "Dart":
//                 Cost = .05;
//                 dmg = "1d4";
//                 Dmg_Type = "Piercing";
//                 Weight = 0;
//                 string[] Properties = {"Finesse", "Thrown", "Range 20/60"};
//                 isSimple = true;
//                 break;
//             case "Shortbow":
//                 Cost = 25;
//                 dmg = "1d6";
//                 Dmg_Type = "Piercing";
//                 Weight = 2;
//                 string[] Properties = {"Ammunition", "Range 80/320", "Two-Handed"};
//                 isSimple = true;
//                 break;
//             case "Sling":
//                 Cost = .1;
//                 dmg = "1d4";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 0;
//                 string[] Properties = {"Ammunition", "Range 30/120"};
//                 isSimple = true;
//                 break;
//             case "Battleaxe":
//                 Cost = 10;
//                 dmg = "1d8";
//                 Dmg_Type = "Slashing";
//                 Weight = 4;
//                 string[] Properties = {"Versatile", "1d10"};
//                 isSimple = false;
//                 break;
//             case "Flail":
//                 Cost = 10;
//                 dmg = "1d8";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 2;
//                 string[] Properties = {"-"};
//                 isSimple = false;
//                 break;
//             case "Glaive":
//                 Cost = 20;
//                 dmg = "1d10";
//                 Dmg_Type = "Slashing";
//                 Weight = 6;
//                 string[] Properties = {"Heavy", "Reach", "Two-Handed"};
//                 isSimple = false;
//                 break;
//             case "Greataxe":
//                 Cost = 30;
//                 dmg = "1d12";
//                 Dmg_Type = "Slashing";
//                 Weight = 7;
//                 string[] Properties = {"Heavy", "Two-Handed"};
//                 isSimple = false;
//                 break;
//             case "Greatsword":
//                 Cost = 50;
//                 dmg = "2d6";
//                 Dmg_Type = "Slashing";
//                 Weight = 6;
//                 string[] Properties = {"Heavy", "Two-Handed"};
//                 isSimple = false;
//                 break;
//             case "Halberd":
//                 Cost = 20;
//                 dmg = "1d10";
//                 Dmg_Type = "Slashing";
//                 Weight = 6;
//                 string[] Properties = {"Reach", "Reach", "Two-Handed"};
//                 isSimple = false;
//                 break;
//             case "Lance":
//                 Cost = 10;
//                 dmg = "1d12";
//                 Dmg_Type = "Piercing";
//                 Weight = 6;
//                 string[] Properties = {"Reach", "Special"};
//                 isSimple = false;
//                 break;
//             case "Longsword":
//                 Cost = 15;
//                 dmg = "1d8";
//                 Dmg_Type = "Slashing";
//                 Weight = 3;
//                 string[] Properties = {"Versatile", "1d10"};
//                 isSimple = false;
//                 break;
//             case "Maul":
//                 Cost = 10;
//                 dmg = "2d6";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 10;
//                 string[] Properties = {"Heavy", "Two-Handed"};
//                 isSimple = false;
//                 break;
//             case "Morningstar":
//                 Cost = 15;
//                 dmg = "1d8";
//                 Dmg_Type = "Piercing";
//                 Weight = 4;
//                 string[] Properties = {"-"};
//                 isSimple = false;
//                 break;
//             case "Pike":
//                 Cost = 5;
//                 dmg = "1d10";
//                 Dmg_Type = "Piercing";
//                 Weight = 18;
//                 string[] Properties = {"Heavy", "Reach", "Two-Handed"};
//                 isSimple = false;
//                 break;
//             case "Rapier":
//                 Cost = 25;
//                 dmg = "1d8";
//                 Dmg_Type = "Piercing";
//                 Weight = 2;
//                 string[] Properties = {"Finesse"};
//                 isSimple = false;
//                 break;
//             case "Scimitar":
//                 Cost = 25;
//                 dmg = "1d6";
//                 Dmg_Type = "Slashing";
//                 Weight = 3;
//                 string[] Properties = {"Finesse", "Light"};
//                 isSimple = false;
//                 break;
//             case "Shortsword":
//                 Cost = 10;
//                 dmg = "1d6";
//                 Dmg_Type = "Piercing";
//                 Weight = 2;
//                 string[] Properties = {"Finesse", "Light"};
//                 isSimple = false;
//                 break;
//             case "Trident":
//                 Cost = 5;
//                 dmg = "1d6";
//                 Dmg_Type = "Piercing";
//                 Weight = 4;
//                 string[] Properties = {"Thrown", "Range 20/60", "Versatile", "1d8"};
//                 isSimple = false;
//                 break;
//             case "War Pick":
//                 Cost = 5;
//                 dmg = "1d6";
//                 Dmg_Type = "Piercing";
//                 Weight = 2;
//                 string[] Properties = {"-"};
//                 isSimple = false;
//                 break;
//             case "Warhammer":
//                 Cost = 15;
//                 dmg = "1d8";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 2;
//                 string[] Properties = {"Versatile", "1d10"};
//                 isSimple = false;
//                 break;
//             case "Whip":
//                 Cost = 2;
//                 dmg = "1d4";
//                 Dmg_Type = "Slashing";
//                 Weight = 3;
//                 string[] Properties = {"Finesse", "Light"};
//                 isSimple = false;
//                 break;
//             case "Blowgun":
//                 Cost = 10;
//                 dmg = "1d1";
//                 Dmg_Type = "Piercing";
//                 Weight = 1;
//                 string[] Properties = {"Ammunition", "Range 25/100", "Loading"};
//                 isSimple = false;
//                 break;
//             case "Hand Crossbow":
//                 Cost = 75;
//                 dmg = "1d6";
//                 Dmg_Type = "Piercing";
//                 Weight = 3;
//                 string[] Properties = {"Ammunition", "Range 30/120", "Light", "Loading"};
//                 isSimple = false;
//                 break;
//             case "Heavy Crossbow":
//                 Cost = 50;
//                 dmg = "1d10";
//                 Dmg_Type = "Piercing";
//                 Weight = 18;
//                 string[] Properties = {"Ammunition", "Range 100/400", "Heavy", "Loading", "Two-Handed"};
//                 isSimple = false;
//                 break;
//             case "Longbow":
//                 Cost = 50;
//                 dmg = "1d8";
//                 Dmg_Type = "Piercing";
//                 Weight = 2;
//                 string[] Properties = {"Ammunition", "Range 150/600", "Heavy", "Two-Handed"};
//                 isSimple = false;
//                 break;
//             case "Net":
//                 Cost = 1;
//                 dmg = "0d1";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 3;
//                 string[] Properties = {"Special", "Thrown", "Range 5/15"};
//                 isSimple = false;
//                 break;
//             default:
//                 Cost = 0;
//                 dmg = "0d1";
//                 Dmg_Type = "Bludgeoning";
//                 Weight = 0;
//                 string[] Properties = {"-"};
//                 isSimple = true;
//                 Console.WriteLine("ERROR: UNKNOWN WEAPON CREATED");
//                 break;
//         }