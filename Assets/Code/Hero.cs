using System;
public class Hero: Character
{
    public Hero()
    {

    }

    public Hero(string name) : base(name)
    {

    }

    public void createRandomStatus(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = level + (int)(random.Next(level)*0.5);
        this.MagicPoints = (int)(level*0) + (int)(random.Next(level)*0.2);
        this.Stamina = random.Next(level) - (int)(random.Next(level)/5);
        this.Speed = random.Next(level) - (int)(random.Next(level)/5);
        this.Defense = random.Next(level) - (int)(random.Next(level)/5);
        this.Attack = random.Next(level) - (int)(random.Next(level)/5);
        this.Lucky = random.Next(level) - (int)(random.Next(level)/5);
        this.Live = true;
        this.Experience = 0;
    }

    
    public void createMagicHero(int level) 
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = level;
        this.MagicPoints = (int)(level) + (int)(random.Next(level)*0.5);
        this.Stamina = random.Next(level) - (int)(random.Next(level));
        this.Speed = random.Next(level) - (int)(random.Next(level)/2);
        this.Defense = random.Next(level) - (int)(random.Next(level));
        this.Attack = random.Next(level) - (int)(random.Next(level));
        this.Lucky = random.Next(level) - (int)(random.Next(level));
        this.Live = true;
        this.Experience = 0;
    }
    
    public void createBarbarianHero(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level*2) + (int)(random.Next(level)*0.5);
        this.MagicPoints = (int)(level*0) + (int)(random.Next(level) + 1);
        this.Stamina = random.Next(level) - (int)(random.Next(level)/10);
        this.Speed = random.Next(level) - (int)(random.Next(level)) + 1;
        this.Defense = random.Next(level) - (int)(random.Next(level));
        this.Attack = random.Next(level) - (int)(random.Next(level)) + 1;
        this.Lucky = (int)random.Next(level)/20;
        this.Live = true;
        this.Experience = 0;
    }
    
    public void createTankHero(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level)*3 + (int)(random.Next(level));
        this.MagicPoints = (int)(level/20);
        this.Stamina = random.Next(level) - (int)(random.Next(level)/5);
        this.Speed = random.Next(level)/10;
        this.Defense = random.Next(level)*2 - (int)(random.Next(level));
        this.Attack = (int)random.Next(level)/20;
        this.Lucky = (int)random.Next(level)/30;
        this.Live = true;
        this.Experience = 0;
    }
    
    public void createDPSHero(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level);
        this.MagicPoints = (int)(level) + (int)(random.Next(level)/10);
        this.Stamina = random.Next(level)/15;
        this.Speed = random.Next(level) - (int)(random.Next(level));
        this.Defense = random.Next(level)/15;
        this.Attack = random.Next(level)*2 - (int)(random.Next(level));
        this.Lucky = random.Next(level);
        this.Live = true;
        this.Experience = 0;
    }
    
    public void createSupportHero(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level) + (int)(random.Next(level)*0.2);
        this.MagicPoints = (level)*2 - (int)(random.Next(level));
        this.Stamina = random.Next(level);
        this.Speed = random.Next(level) - (int)(random.Next(level));
        this.Defense = random.Next(level);
        this.Attack = random.Next(level) - (int)(random.Next(level));
        this.Lucky = random.Next(level)*2;
        this.Live = true;
        this.Experience = 0;
    }



}