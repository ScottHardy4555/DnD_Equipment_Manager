using System;

/*
TO DO:
    Make sure all properties/field are initiated propperly
    Finish base constructor
    Create a constructor for a manually created weapon
    Create a method that upgrades the quality of the weapon
    Create methods that give the weapon mythril and adamantine properites
*/



namespace BasicClasses
{
  class Weapon
  {
    //Properites
    public bool isRanged; //made
    public int LongRange; //made
    public int ShortRange; //made
    public bool isFinesse;
    public bool isSimple;
    public bool isVersatile;
    public bool isMythril;
    public bool isAdamantine;
    public int Quality;

    private static int WeaponCount;

    //Initiates the class
    static Weapon()
    {
        WeaponCount = 0;
    }

    //Standard constructer
    //Takes a given name and automatically fills out a pre-determined Weapon from the PHB
    //UNFINISHED
    public Weapon (string name)
    {
        WeaponCount++;
        Name = name;
        string dmg = "";
        
        //Inititates the weapon based on the name given
        //TO DO: double check this works
        switch (name)
        {
            case "Club":
                Cost = .1;
                dmg = "1d4";
                Dmg_Type = "Bludgeoning";
                Weight = 2;
                Properties = {"Light"};
                isSimple = true;
                break;
            case "Dagger":
                Cost = 2;
                dmg = "1d4";
                Dmg_Type = "Piercing";
                Weight = 1;
                Properties = {"Finesse", "Light", "Thrown", "Range: 20/60"};
                isSimple = true;
                break;
            case "Greatclub":
                Cost = .2;
                dmg = "1d8";
                Dmg_Type = "Bludgeoning";
                Weight = 10;
                Properties = {"Two-handed"};
                isSimple = true;
                break;
            case "Handaxe":
                Cost = 5;
                dmg = "1d6";
                Dmg_Type = "Slashing";
                Weight = 2;
                Properties = {"Light", "Thrown", "Range 20/60"};
                isSimple = true;
                break;
            case "Javelin":
                Cost = .5;
                dmg = "1d6";
                Dmg_Type = "Piercing";
                Weight = 2;
                Properties = {"Thrown", "Range 30/120"};
                isSimple = true;
                break;
            case "Light Hammer":
                Cost = 2;
                dmg = "1d4";
                Dmg_Type = "Bludgeoning";
                Weight = 2;
                Properties = {"Light", "Thrown", "Range 20/60"};
                isSimple = true;
                break;
            case "Mace":
                Cost = 5;
                dmg = "1d6";
                Dmg_Type = "Bludgeoning";
                Weight = 4;
                Properties = {"-"};
                isSimple = true;
                break;
            case "Quarterstaff":
                Cost = .2;
                dmg = "1d6";
                Dmg_Type = "Bludgeoning";
                Weight = 4;
                Properties = {"Versatile", "1d8"};
                isSimple = true;
                break;
            case "Sickle":
                Cost = 1;
                dmg = "1d4";
                Dmg_Type = "Slashing";
                Weight = 2;
                Properties = {"Light"};
                isSimple = true;
                break;
            case "Light Crossbow":
                Cost = 25;
                dmg = "1d8";
                Dmg_Type = "Piercing";
                Weight = 5;
                Properties = {"Ammunition", "Range 80/320", "Loading", "Two-Handed"};
                isSimple = true;
                break;
            case "Dart":
                Cost = .05;
                dmg = "1d4";
                Dmg_Type = "Piercing";
                Weight = 0;
                Properties = {"Finesse", "Thrown", "Range 20/60"};
                isSimple = true;
                break;
            case "Shortbow":
                Cost = 25;
                dmg = "1d6";
                Dmg_Type = "Piercing";
                Weight = 2;
                Properties = {"Ammunition", "Range 80/320", "Two-Handed"};
                isSimple = true;
                break;
            case "Sling":
                Cost = .1;
                dmg = "1d4";
                Dmg_Type = "Bludgeoning";
                Weight = 0;
                Properties = {"Ammunition", "Range 30/120"};
                isSimple = true;
                break;
            case "Battleaxe":
                Cost = 10;
                dmg = "1d8";
                Dmg_Type = "Slashing";
                Weight = 4;
                Properties = {"Versatile", "1d10"};
                isSimple = false;
                break;
            case "Flail":
                Cost = 10;
                dmg = "1d8";
                Dmg_Type = "Bludgeoning";
                Weight = 2;
                Properties = {"-"};
                isSimple = false;
                break;
            case "Glaive":
                Cost = 20;
                dmg = "1d10";
                Dmg_Type = "Slashing";
                Weight = 6;
                Properties = {"Heavy", "Reach", "Two-Handed"};
                isSimple = false;
                break;
            case "Greataxe":
                Cost = 30;
                dmg = "1d12";
                Dmg_Type = "Slashing";
                Weight = 7;
                Properties = {"Heavy", "Two-Handed"};
                isSimple = false;
                break;
            case "Greatsword":
                Cost = 50;
                dmg = "2d6";
                Dmg_Type = "Slashing";
                Weight = 6;
                Properties = {"Heavy", "Two-Handed"};
                isSimple = false;
                break;
            case "Halberd":
                Cost = 20;
                dmg = "1d10";
                Dmg_Type = "Slashing";
                Weight = 6;
                Properties = {"Reach", "Reach", "Two-Handed"};
                isSimple = false;
                break;
            case "Lance":
                Cost = 10;
                dmg = "1d12";
                Dmg_Type = "Piercing";
                Weight = 6;
                Properties = {"Reach", "Special"};
                isSimple = false;
                break;
            case "Longsword":
                Cost = 15;
                dmg = "1d8";
                Dmg_Type = "Slashing";
                Weight = 3;
                Properties = {"Versatile", "1d10"};
                isSimple = false;
                break;
            case "Maul":
                Cost = 10;
                dmg = "2d6";
                Dmg_Type = "Bludgeoning";
                Weight = 10;
                Properties = {"Heavy", "Two-Handed"};
                isSimple = false;
                break;
            case "Morningstar":
                Cost = 15;
                dmg = "1d8";
                Dmg_Type = "Piercing";
                Weight = 4;
                Properties = {"-"};
                isSimple = false;
                break;
            case "Pike":
                Cost = 5;
                dmg = "1d10";
                Dmg_Type = "Piercing";
                Weight = 18;
                Properties = {"Heavy", "Reach", "Two-Handed"};
                isSimple = false;
                break;
            case "Rapier":
                Cost = 25;
                dmg = "1d8";
                Dmg_Type = "Piercing";
                Weight = 2;
                Properties = {"Finesse"};
                isSimple = false;
                break;
            case "Scimitar":
                Cost = 25;
                dmg = "1d6";
                Dmg_Type = "Slashing";
                Weight = 3;
                Properties = {"Finesse", "Light"};
                isSimple = false;
                break;
            case "Shortsword":
                Cost = 10;
                dmg = "1d6";
                Dmg_Type = "Piercing";
                Weight = 2;
                Properties = {"Finesse", "Light"};
                isSimple = false;
                break;
            case "Trident":
                Cost = 5;
                dmg = "1d6";
                Dmg_Type = "Piercing";
                Weight = 4;
                Properties = {"Thrown", "Range 20/60", "Versatile", "1d8"};
                isSimple = false;
                break;
            case "War Pick":
                Cost = 5;
                dmg = "1d6";
                Dmg_Type = "Piercing";
                Weight = 2;
                Properties = {"-"};
                isSimple = false;
                break;
            case "Warhammer":
                Cost = 15;
                dmg = "1d8";
                Dmg_Type = "Bludgeoning";
                Weight = 2;
                Properties = {"Versatile", "1d10"};
                isSimple = false;
                break;
            case "Whip":
                Cost = 2;
                dmg = "1d4";
                Dmg_Type = "Slashing";
                Weight = 3;
                Properties = {"Finesse", "Light"};
                isSimple = false;
                break;
            case "Blowgun":
                Cost = 10;
                dmg = "1d1";
                Dmg_Type = "Piercing";
                Weight = 1;
                Properties = {"Ammunition", "Range 25/100", "Loading"};
                isSimple = false;
                break;
            case "Hand Crossbow":
                Cost = 75;
                dmg = "1d6";
                Dmg_Type = "Piercing";
                Weight = 3;
                Properties = {"Ammunition", "Range 30/120", "Light", "Loading"};
                isSimple = false;
                break;
            case "Heavy Crossbow":
                Cost = 50;
                dmg = "1d10";
                Dmg_Type = "Piercing";
                Weight = 18;
                Properties = {"Ammunition", "Range 100/400", "Heavy", "Loading", "Two-Handed"};
                isSimple = false;
                break;
            case "Longbow":
                Cost = 50;
                dmg = "1d8";
                Dmg_Type = "Piercing";
                Weight = 2;
                Properties = {"Ammunition", "Range 150/600", "Heavy", "Two-Handed"};
                isSimple = false;
                break;
            case "Net":
                Cost = 1;
                dmg = "0d1";
                Dmg_Type = "Bludgeoning";
                Weight = 3;
                Properties = {"Special", "Thrown", "Range 5/15"};
                isSimple = false;
                break;
            default:
                Cost = 0;
                dmg = "0d1";
                Dmg_Type = "Bludgeoning";
                Weight = 0;
                Properties = {"-"};
                isSimple = true;
                Console.WriteLine("ERROR: UNKNOWN WEAPON CREATED")
                break;
        }

        //Sets the dice type and number
        Dice_Number = getDiceNum(dmg);
        Dice_Type = getDiceType(dmg);

        //Checks for the ranged property and sets the ranges
        //TO DO: double check this works
        if (
            Array.IndexOf(Properties, "Thrown") != -1 || 
            Array.IndexOf(Properties, "Ammunition") != -1
            ) 
        { 
            isRanged = true;
            string r1, r2;

            if (Array.IndexOf(Properties, "Thrown") != -1) { r1 = Properties[Array.IndexOf(Properties, "Thrown") + 1]; }
            else { r1 = Properties[Array.IndexOf(Properties, "Ammunition") + 1]; }

            r2 = r1.Substring(r1.IndexOf(" "));

            ShortRange = r2.Substring(0, r2.IndexOf("/"))
            LongRange = r2.Substring(r2.IndexOf("/"))
        }
        else { isRanged = false; LongRange = 0; ShortRange = 0; }

        //Sets the isFinesse property
        if (Array.IndexOf(properites, "Finesse") == -1) { isFinesse = false; }
        else { isFinesse = true; }

        //Sets the isVersatile property and gets the dmg dice set
        if (Array.IndexOf(Properties, "Versatile") != -1)
        {
            isVersatile = true;
            Versatile_Dice_Number = getDiceNum( Properties[Array.IndexOf(Properties, "Versatile")+1] );
            Versatile_Dice_Type = getDiceType( Properties[Array.IndexOf(Properties, "Versatile")+1] );
        }
        else { isVersatile = false; }
    }



    //Fields
    public string Name { get; set; }
    public double Cost { get; private set; }
    public int Dice_Number { get; private set; }
    public int Dice_Type { get; private set; }
    public string Dmg_Type { get; private set; }
    public int Weight { get; private set; }
    public int Versatile_Dice_Number { get; private set; }
    public int Versatile_Dice_Type { get; private set; }
    public string[] Properties { get; private set; }

    //Displays the attributes of the Weapon object to the Console
    public void PrintWeapon()
    {
        string printed = $"Name: ";

        //Adds quality and adamantine/mythril to name if applicable
        if (quality > 0) { printed = $"{printed} +{this.quality} "; }
        if (isAdamantine) { printed = $"{printed} Adamantine "; }
        if (isMythril) { printed = $"{printed} Mythril "; }

        printed = $"{printed}{this.Name}\nCost: {this.Cost}\nDamage Dice: {this.Dice_Number}d{this.Dice_Type} {this.Dmg_type} damage\nWeight: {this.Weight}";
        string tempP = "";
        foreach(string p in this.Properties)
        {
            if (p == this.Properties[0]) { tempP = p; continue; }
            tempP = $"{tempP}, {p}";
        }
        printed = $"{printed}\nProperties: {tempP}";
        
        Console.WriteLine(printed);
    }

    //Finds the number of dice rolled when dealing damage
    private int getDiceNum (string dice)
    {
        try
        {
            string num = dice.Substring(0, dice.IndexOf("d"));
            return Int32.Parse(num);
        }
        catch (System.Exception)
        {
            Console.WriteLine($"ERROR: This is a bad error. Oh no, oh no. Please help us all.");
            return 0;
        }
    }

    //Finds the type of dice rolled when dealing damage
    private int getDiceType (string dice)
    {
        try
        {
            string num = dice.Substring(dice.IndexOf("d")+1);
            return Int32.Parse(num);
        }
        catch (System.Exception)
        {
            Console.WriteLine("ERROR: Attempted to convert impropper string in Weapon.getDiceType, returning default value of 0\nFailed: {num}, Idiot");
            return 0;
        }
    }

    //Returns a random number to simulate a d20 roll
    //Adds a modifier and the quality of the weapon and rolls for advantage or disadvantage if applicable
    //adv: 0 = normal roll, 1 = advantage roll, 2 = disadvantage roll
    public int Attack (int mod, int adv = 0)
    {
        Random randy = new Random();
        int result = 0;
        if (adv == 0) { result = randy.Next(20)+1+mod+this.quality; }
        else if (adv == 1) { result = Math.Max(randy.Next(20) + 1 + mod + this.quality, randy.Next(20) + 1 + mod + this.quality); }
        else { result = Math.Min(randy.Next(20) + 1 + mod + this.quality, randy.Next(20) + 1 + mod); }

        return result;
    }

    //Returns a random number based on the number of "dice" and the type of "die" used
    //Adds a modifer and the quality of the weapon
    public int DoDamage ()
    {
        Random randy = new Random(int mod);
        int total = 0;
        for (int x=0; x<Dice_Number; x++) { total += randy.Next(Dice_Type) + 1 + mod + this.quality; }

        return total;
    }

    //Upgrades the quality of the weapon
    public void Upgrade ()
    {
        if (this.quality < 3) { this.quality++; }
    }

    //Downgrades the quality of the weapon
    public void Downgrade ()
    {
        if (this.quality > 0) { this.quality--; }
    }

    //Toggles the adamantine property of the weapon
    //Cannot be adamantine if already mythril
    public void ToggleAdamantine()
    {
        if (!isMythril) { isAdamantine = !isAdamantine; }
    }

    //Toggles the mythril property of the weapon
    //Cannot be mythril if already adamantine
    public void ToggleMythril()
    {
        if (!isAdamantine) { isMythril = !isMythril; }
    }
  }
}