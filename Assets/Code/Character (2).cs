using System;
public class Character
{
    // Attributes    
    private string name;
    private int lifePoints;    
    private int magicPoints;
    private int stamina;
    private int speed;
    private int defense;
    private int attack;
    private int lucky;
    private bool live;
    private int level;
    private int experience;

    // Constructor
    public Character(string Name, int LifePoints, int MagicPoints, int Stamina, int Speed, int Defense, int Attack, int Lucky, int Level)
    {
        name = Name;
        lifePoints = LifePoints;
        magicPoints = MagicPoints;
        stamina = Stamina;
        speed = Speed;
        defense =Defense;
        attack = Attack;
        lucky = Lucky;
        level = Level;
    }

    public Character(string Name)
    {
        name = Name;
    }

    public Character()
    {

    }

    // Methods
    public int criticalHit(int lucky)
    {
        Random random = new Random();
        int critHit = random.Next(255);
        int accuracy = random.Next(255);
        int hit = 1;
        if(critHit > accuracy - lucky && critHit < accuracy + lucky)
        {
            hit = 2;
        }
        return hit;
    }

    // Properties
    public string Name{
        get { return name; }
        set { name = value; }
    }

    public int LifePoints{
        get { return lifePoints;}
        set { lifePoints = value;}
    }

    public int MagicPoints{
        get { return magicPoints; }
        set { magicPoints = value; }
    }
    
    public int Stamina{
        get { return stamina; }
        set { stamina = value; }
    }
    
    public int Speed{
        get { return speed; }
        set { speed = value; }
    }
    
    public int Defense{
        get { return defense; }
        set { defense = value; }
    }
    public int Attack { 
        get { return attack; }
        set { attack = value; }    
    }
    public int Level { 
        get { return level; }
        set { level = value; }    
    }

    public int Experience{
        get { return experience; }
        set { experience = value; }
    }

    public bool Live{
        get { return live;}
        set { live = value;}
    }
    public int Lucky{
        get { return lucky;}
        set { lucky = value;}
    }

}