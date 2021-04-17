using UnityEngine;
using System;

public class BattleController : MonoBehaviour {


    void Start()
    {
        // Inicialización de objetos
        Character generic = new Character("gen1", 10, 5, 2, 1, 2, 1, 0, 1);
        Debug.Log("El nombre del caracter es:  " + generic.Name);

        Enemy enemigo1 = new Enemy();
        enemigo1.Name = "ene1";
        Debug.Log("El nombre del enemigo es: " + enemigo1.Name);

        // Inicialización de objetos con constructor en clase Base: 
        // Se manda parámetro de constructor a la clase base para que se
        // Inicialice en la clase Character y no en Enemy
        Enemy enemigo2 = new Enemy("BaseEnemy");
        Debug.Log("El nombre del enemigo es: " + enemigo2.Name);
        enemigo2.createRandomStatus(10);
        Debug.Log("Los LifePoints del enemigo2 es: " + enemigo2.LifePoints);

        Enemy fool = new Enemy();
        fool.createFoolEnemy(5);
        Debug.Log("Este son los life points del fool enemy " + fool.LifePoints);

    }

    // A1 (3 PUNTOS)
    public void EnemyAmbush(Enemy enemy, Hero hero)
    {
        
        int ambush = (int)((enemy.Attack)*2)*(enemy.Speed/hero.Speed);
        hero.LifePoints -= ambush;

        //----Mientras que la vida del enemigo sea mayor a 0 o mientras que la vida del heroe sea mayor a 0
        while(enemy.LifePoints>0 | hero.LifePoints > 0)
        {
            //---- Si el enemigo es más rapido que el heroe enotnces empesará a luchar, la vida del heroe se le restará
            //---- el ataque del enemigo por el ataque critico si el enemigo tiene suerte.
            //---- A la vida del enemigo se le restará el ataque por heroe 
            if(enemy.Speed >= hero.Speed)
            {
                hero.LifePoints -= (enemy.Attack)*enemy.criticalHit(enemy.Lucky) - hero.Defense;
                enemy.LifePoints -= (hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense;
            }
            //----
            else
            {
                enemy.LifePoints -= (hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense;
                hero.LifePoints -= (enemy.Attack)*enemy.criticalHit(enemy.Lucky) - hero.Defense;
            }
        }
    }

    // A2 (2 PUNTOS)
    public void MagicAttack(Enemy enemy, Hero hero)
    {
        //---- si la velocidad del enemigo es mayor o igual a la velocidad del heroe y los puntos de magia del enemigo son mayor a 4 entonces
        //---- se le resta a la vida delheroe el daño mahigico del enemigo con su critico (si este logra hacerlo), pero al ataque se le resta la defensa del heroe
        if(enemy.Speed >= hero.Speed && enemy.MagicPoints > 4)
        {
            hero.LifePoints -= (enemy.Attack)*2*enemy.criticalHit(enemy.Lucky) - hero.Defense;
        }
        //---- pero si la velocidad de enemigo es menor a la del heroe y su magia es mayor a 4 entonces el enemigo será atacado por el heroe
        //----- con multiplicacion de su critico (si este lo hace) y a esto se le resta la defensa del enemigo
        else if(enemy.Speed < hero.Speed && hero.MagicPoints > 4)
        {
            enemy.LifePoints -= (hero.Attack)*hero.criticalHit(hero.Lucky) - enemy.Defense;
        }
    }

    // A3 (2 PUNTOS)
    public void CounterAttack(Enemy enemy, Hero hero)
    {
        if(hero.MagicPoints > 2)
        {            
            //---- si los puntos del heroe son mayor a dos enyonces el enemigo recivirá de regreso su ataque por el critico del heroe, si lo logra hacer, por 1.5 y a esto se le resta la defensa del eneemigo 
            enemy.LifePoints -= (int)((enemy.Attack)*hero.criticalHit(hero.Lucky)*1.5 - enemy.Defense);
            hero.MagicPoints -= 2;
        }
        
    }
    
    // A4 (4 PUNTOS)
    public void UnitedAttack(Enemy enemy, Hero heroA, Hero heroB, Hero heroC)
    {
        //---Si el ennemigo es mas velos que la division de la suma de los tres heroes entonces crea de forma aleatoria tres situaciones
        if(enemy.Speed >= (int)(heroA.Speed + heroB.Speed + heroC.Speed)/3)
        {
            System.Random random = new System.Random();

            //---- la situacion1: si la vida del heroe 1 es menor o igual al ataque del enemigo por el ataque critico (si este se activa) menos la defensa que posea el heroe 1
            //---- la situacion2: si la vida del heroe 2 es menor o igual al ataque del enemigo por el ataque critico (si este se activa) menos la defensa que posea el heroe 2
            //---- la situacion3: si la vida del heroe 3 es menor o igual al ataque del enemigo por el ataque critico (si este se activa) menos la defensa que posea el heroe 3
            switch (random.Next(3))
            {
                case 0:
                heroA.LifePoints -= (enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroA.Defense;
                break;

                case 1:
                heroB.LifePoints -= (enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroB.Defense;
                break;

                case 2:
                heroC.LifePoints -= (enemy.Attack)*enemy.criticalHit(enemy.Lucky) - heroC.Defense;
                break;
            }            
        }
        //---- Si la velocidad del enemigo es menor a la de los heroes entre 3 
        else
        {
            //---- los heroes atacaran y la vida del enemigo se verá afectada por el ataque del heroe 1 por su critico, si este se dá, más 
            //--- el ataque critico del heroe 2 y 3 si estos lo activan menos ladefensa que posea el enemigo.
            enemy.LifePoints -= ((heroA.Attack)*heroA.criticalHit(heroA.Lucky) +
            (heroB.Attack)*heroB.criticalHit(heroB.Lucky) + 
            (heroC.Attack)*heroC.criticalHit(heroC.Lucky) - enemy.Defense);
        }
    }

    // B1 (1 PUNTO)
    public void DefendFromEnemy(Enemy enemy , Hero hero)
    {
        //---- la vida del heroe será la resta de la vida del heroe y la division del ataque normal por el ataque critico por la suerte del enemigo entre 
        hero.LifePoints = hero.LifePoints - ((enemy.Attack)*enemy.criticalHit(enemy.Lucky))/2;
    }

    // B2 (1 PUNTO)
    public void EscapeFromEnemies(Enemy enemyA, Enemy enemyB, Hero heroA,Hero heroB, Hero heroC)
    {
        bool succesfulyEscaped = false;
        //----   si la velocidad del enemigo 1 + el enemigo 2 es mayor a la del heroe 1, heroe 2 y heroe 3
        if(enemyA.Speed + enemyB.Speed > heroA.Speed + heroB.Speed + heroC.Speed)
        {
            succesfulyEscaped = true;
        }
    }
    // B3 (1 PUNTO)
    public void GetExperience(Enemy enemy, Hero heroA, Hero heroB, Hero heroC)
    {
        //---- La experiencia de el heroe 1, 2, 3 será igual al nivel del enemigo entre 3
        heroA.Experience = (int)enemy.Level/3;
        heroB.Experience = (int)enemy.Level/3;
        heroC.Experience = (int)enemy.Level/3;
    }

}