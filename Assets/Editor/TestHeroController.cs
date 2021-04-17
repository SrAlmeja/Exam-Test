using NUnit.Framework;

public class TestHeroController
{
    [Test]
    //A1A
    public void A1_WhoWillWin()
    {
        //arrange
        Enemy heIsAFool = new Enemy();
        Hero meeediiiiic = new Hero();
        var level = 10;

        //act
        heIsAFool.createFoolEnemy(level);
        meeediiiiic.createSupportHero(level);
        heIsAFool.Speed = 15;
        meeediiiiic.Speed = 5;
        //assert
        Assert.That(meeediiiiic.LifePoints, Is.LessThan(12));
    }

    
    [Test]
    //A1B
    public void A1_WhoWillWin2()
    {
        //arrange
        Enemy heIsAFool = new Enemy();
        Hero meeediiiiic = new Hero();
        var level = 10;

        //act
        heIsAFool.createFoolEnemy(level);
        meeediiiiic.createSupportHero(level);
        heIsAFool.Speed = 5;
        meeediiiiic.Speed = 15;

        //assert
        Assert.That(heIsAFool.LifePoints, Is.LessThan(12));
    }
    //A2A
    [Test]
    public void MagicAttack()
    {
        //arrange
        Enemy theWizard = new Enemy();
        var DrStrange = new Hero();
        var level = 10;
        //Act
        theWizard.createMagicEnemy(level);
        DrStrange.createMagicHero(level);
        DrStrange.Speed = 15;
        DrStrange.MagicPoints = 5;

        Assert.That(DrStrange.LifePoints, Is.LessThan(141));
    }

    //A2B
    [Test]
    public void CounterAttack()
{
    //Arrange
    Enemy theWizard = new Enemy();
    var DrStrange = new Hero();
    var level = 10;

    //Act
    theWizard.createMagicEnemy(level);
    DrStrange.createMagicHero(level);
    DrStrange.Speed = 15;
    DrStrange.MagicPoints = 5;

    Assert.That(theWizard.LifePoints, Is.LessThan(141));
}


[Test]
    //A3
    public void HeroSurvivingPosivilityA()
    {
        //Arrange
        Enemy heIsAFool = new Enemy();
        Hero meeediiiiic = new Hero();
        var level = 21;
        var enemy = heIsAFool;
        var hero = meeediiiiic;
        BattleController ambush = new BattleController();

        //Act
        ambush.EnemyAmbush(enemy, hero);

        //Assert
        Assert.That(hero.LifePoints, Is.LessThan(1));

    }


    [Test]
    //A4-A
    public void A4_Ruuun()
    {
        //Arrange
        Enemy AtilaTheUno = new Enemy();
        Hero meeediiiiic = new Hero();
        Hero DrStrange = new Hero();
        Hero personalized = new Hero();
        var level = 19;
        var enemy = AtilaTheUno;
        var hero = meeediiiiic;
        var hero2 = DrStrange;
        var hero3 = personalized;
        BattleController ambush = new BattleController();


        //Act
        enemy.Speed -= ((hero.Speed + hero2.Speed + hero3.Speed) / 3);

        //Assert
        Assert.That(enemy.LifePoints, Is.LessThan(38));
    }

    [Test]
    //A4-B
    public void A4_Situations()
    {
        //Arrange
        Enemy AtilaTheUno = new Enemy();
        Hero meeediiiiic = new Hero();
        Hero DrStrange = new Hero();
        Hero personalized = new Hero();
        var level = 19;
        var enemy = AtilaTheUno;
        var hero = meeediiiiic;
        var hero2 = DrStrange;
        var hero3 = personalized;
        BattleController ambush = new BattleController();


        //Act
        enemy.Speed -= ((hero.Speed + hero2.Speed + hero3.Speed) / 3);

        //Assert
        Assert.That(enemy.Speed, Is.GreaterThan (-23));
    }


    [Test]
    //A4-C
    public void Surviving_Chance1 ()
    {
        //Arrange
        Enemy AtilaTheUno = new Enemy();
        Hero meeediiiiic = new Hero();
        var level = 19;
        BattleController ambush = new BattleController();


        //Act
        AtilaTheUno.createBarbarianEnemy(level);
        meeediiiiic.createSupportHero(level);
        meeediiiiic.LifePoints -= ((AtilaTheUno.Attack)*AtilaTheUno.criticalHit(AtilaTheUno.Lucky));

        //Assert
        Assert.That(AtilaTheUno.Speed, Is.LessThan(19));
    }

    [Test]
    //B1
    public void Defend()
    {
        //Arrange
        Enemy heIsAFool = new Enemy();
        Hero DPS = new Hero();
        var level = 9;

        BattleController defending = new BattleController();

        //Act
        heIsAFool.createFoolEnemy(level);
        DPS.createDPSHero(level);
        defending.DefendFromEnemy(heIsAFool, DPS);

        //Assert
        Assert.That(DPS.LifePoints, Is.LessThan(10));
    }

    [Test]
    //B2
    public void Escaping()
    {
        //Arrange
        Enemy Taaank = new Enemy();
        Enemy DarkHealer = new Enemy();
        Hero theHealer = new Hero();
        Hero Tank = new Hero();
        Hero DrStrange = new Hero();
        var level = 14;
        float expectedResult;
         
        BattleController escape = new BattleController();

        //Act
        Taaank.createTankEnemy(level);
        DarkHealer.createSupportEnemy(level);
        DrStrange.createMagicHero(level);
        theHealer.createSupportHero(level);
        Tank.createTankHero(level);
        expectedResult = Taaank.Speed + DarkHealer.Speed - (DrStrange.Speed + theHealer.Speed + Tank.Speed);

        //Assert
        Assert.That(expectedResult, Is.LessThan(1));
    }

[Test]
    //B3
    public void TheExpereince()
    {
        //Arrange
        Enemy theWizard = new Enemy();
        Enemy AtilaTheUno = new Enemy();
        Enemy Taaank = new Enemy();
        Hero DrStrange = new Hero();
        Hero Heman = new Hero();
        Hero Tank = new Hero();
        var level = 11;
        BattleController experience = new BattleController();

        //Act
        theWizard.createMagicEnemy(level);
        AtilaTheUno.createBarbarianEnemy(level);
        Taaank.createTankEnemy(level);
        DrStrange.createMagicHero(level);
        Heman.createBarbarianHero(level);
        Tank.createTankHero(level);
        experience.GetExperience(theWizard, DrStrange, Heman, Tank);

        //Assert
        Assert.That(Tank.Experience, Is.LessThan(6));

    }
}