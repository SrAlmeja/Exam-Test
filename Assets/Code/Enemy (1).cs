using System;
public class Enemy: Character
{
    private bool ambush;

    public Enemy()
    {

    }

    public Enemy(string name) : base(name)
    {

    }

    // Axel Jurado 15
    public void createRandomStatus(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level*2) + (int)(random.Next(level)*0.5);
        this.MagicPoints = (int)(level*0.4) + (int)(random.Next(level)*0.2);
        this.Stamina = random.Next(level) - (int)(random.Next(level)/3);
        this.Speed = random.Next(level) - (int)(random.Next(level)/3);
        this.Defense = random.Next(level) - (int)(random.Next(level)/3);
        this.Attack = random.Next(level) - (int)(random.Next(level)/3);
        this.Lucky = random.Next(level) - (int)(random.Next(level)/3);
        this.Live = true;
        this.Experience = 0;
    }

    // Angel Legorreta 17
    public void createMagicEnemy(int level) 
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level) + (int)(random.Next(level)*0.2);
        this.MagicPoints = (int)(level*2) + (int)(random.Next(level)*0.5);
        this.Stamina = random.Next(level) - (int)(random.Next(level)/2);
        this.Speed = random.Next(level) - (int)(random.Next(level)/6);
        this.Defense = random.Next(level) - (int)(random.Next(level));
        this.Attack = random.Next(level) - (int)(random.Next(level));
        this.Lucky = random.Next(level) - (int)(random.Next(level)/20);
        this.Live = true;
        this.Experience = 0;
    }
    // Diana 11
    public void createBarbarianEnemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level*3) + (int)(random.Next(level)*0.5);
        this.MagicPoints = (int)(level*0) + (int)(random.Next(level));
        this.Stamina = random.Next(level)*2 - (int)(random.Next(level)/5);
        this.Speed = random.Next(level)*2 - (int)(random.Next(level));
        this.Defense = random.Next(level) - (int)(random.Next(level));
        this.Attack = random.Next(level)*3 - (int)(random.Next(level));
        this.Lucky = (int)random.Next(level)/10;
        this.Live = true;
        this.Experience = 0;
    }
    // Navarrete 19
    public void createTankEnemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level)*5 + (int)(random.Next(level));
        this.MagicPoints = (int)(level/10);
        this.Stamina = random.Next(level)*2 - (int)(random.Next(level)/2);
        this.Speed = random.Next(level)/5;
        this.Defense = random.Next(level)*5 - (int)(random.Next(level));
        this.Attack = (int)random.Next(level)/10;
        this.Lucky = (int)random.Next(level)/20;
        this.Live = true;
        this.Experience = 0;
    }
    // Oscar Albeart 14
    public void createDPSEnemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level) + (int)(random.Next(level)*0.5);
        this.MagicPoints = (int)(level) + (int)(random.Next(level)/6);
        this.Stamina = random.Next(level)/5;
        this.Speed = random.Next(level)*2 - (int)(random.Next(level));
        this.Defense = random.Next(level)/5;
        this.Attack = random.Next(level)*5 - (int)(random.Next(level));
        this.Lucky = random.Next(level);
        this.Live = true;
        this.Experience = 0;
    }
    // Fer Cossio 25
    public void createSupportEnemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = (level) + (int)(random.Next(level)*0.5);
        this.MagicPoints = (level)*3 - (int)(random.Next(level));
        this.Stamina = random.Next(level);
        this.Speed = random.Next(level) - (int)(random.Next(level));
        this.Defense = random.Next(level);
        this.Attack = random.Next(level)*2 - (int)(random.Next(level));
        this.Lucky = random.Next(level)*5;
        this.Live = true;
        this.Experience = 0;
    }

    public void createFoolEnemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = random.Next(level);
        this.MagicPoints = random.Next(level);
        this.Stamina = random.Next(level);
        this.Speed = random.Next(level);
        this.Defense = random.Next(level);
        this.Attack = random.Next(level);
        this.Lucky = random.Next(level)*10;
        this.Live = true;
        this.Experience = 0;
    }

    // Raymundo 11
    public void createBossEnemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = random.Next(level)*10 - random.Next(level);
        this.MagicPoints = random.Next(level)*5 - random.Next(level);
        this.Stamina = random.Next(level)*5 - random.Next(level);
        this.Speed = random.Next(level)*5 - random.Next(level);
        this.Defense = random.Next(level)*8 - random.Next(level);
        this.Attack = random.Next(level)*8 - random.Next(level);
        this.Lucky = random.Next(level)*5;
        this.Live = true;
        this.Experience = 0;
    }
    
    // Raul Estrada 12
    public void createMiniBossEnemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = random.Next(level)*5 - random.Next(level);
        this.MagicPoints = random.Next(level)*3 - random.Next(level);
        this.Stamina = random.Next(level)*3 - random.Next(level);
        this.Speed = random.Next(level)*3 - random.Next(level);
        this.Defense = random.Next(level)*5 - random.Next(level);
        this.Attack = random.Next(level)*5 - random.Next(level);
        this.Lucky = random.Next(level)*3;
        this.Live = true;
        this.Experience = 0;
    }

    // Aviles 14
    public void createFinalBossEnemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = random.Next(level)*20 - random.Next(level);
        this.MagicPoints = random.Next(level)*10 - random.Next(level);
        this.Stamina = random.Next(level)*10 - random.Next(level);
        this.Speed = random.Next(level)*10 - random.Next(level);
        this.Defense = random.Next(level)*15 - random.Next(level)*2;
        this.Attack = random.Next(level)*15 - random.Next(level)*2;
        this.Lucky = random.Next(level)*10;
        this.Live = true;
        this.Experience = 0;
    }
    public void createFinalBossPhase2Enemy(int level)
    {
        Random random = new Random();
        this.Level = level; 
        this.LifePoints = random.Next(level)*25 - random.Next(level)*2;
        this.MagicPoints = random.Next(level)*15 - random.Next(level)*2;
        this.Stamina = random.Next(level)*15 - random.Next(level)*2;
        this.Speed = random.Next(level)*15 - random.Next(level)*2;
        this.Defense = random.Next(level)*20 - random.Next(level);
        this.Attack = random.Next(level)*20 - random.Next(level);
        this.Lucky = random.Next(level)*15;
        this.Live = true;
        this.Experience = 0;
    }

}