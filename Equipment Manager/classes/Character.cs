using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equipment_Manager.classes
{

    /*
    
    Characteristics of a Character:
    Name
    Class **
        // Maybe make this it's own Class?
        string classFeatures[] **
        string skillOptions[] **
    Level
    Race
        string racialFeatures[]
    Alignment // LG, NN, CE, etc.

    Health:
        int maxHealth *
        int currentHealth ***
        int hitDie *
        int maxHitDie *
        int numHitDie ***
    Proficiency Bonus *
    Speed *
    Armor Class *
    EXP ***

    Stat scores:
        Str
        Dex
        Con
        Int
        Wis
        Cha
    Stat Bonuses *

    Proficiencies:
        string skillProficiencies[]
        string weaponProficiencies[] *
        string armorProficiencies[] *
        string mscProficiencies[] // Launguages/Tools

    Spellcasting **
        //Maybe make this its own Class?
        bool isSpellcaster *
        bool hasRitual *
        bool canPrepare *
        int spellSave *
        int spellAttack *
        string Spell List // Chooseable options
        int maxSpellSlots *
        int currentSpellSlots[] ***
        string spellsKnown[][]
        string spellsPrepared[][] ***

    Feats **
        // BRAIN HURTY

    Inventory **
        Item inventory[] ***
        Item equipment[] ***
        int coinPurse[] ***


    Question: How do we handle conditional features (barbarian's rage, for example)
    Key:
    * = Derivable from pre-existing data, no prompt needed
    ** = Make its own class to inherit
    *** = Requires active tracking
    
    */
    internal class Character
    {
        private string name;
        private int level;
        private string race;
        private string alignment;

        private int maxHealth;
        private int currentHealth;


    }
}
