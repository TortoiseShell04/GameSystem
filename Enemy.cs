namespace GameSystem;

abstract class Enemy
{
    public int HP = 0;
    public int ATK = 0;
    public string Disc = "";
}

class OverworldEnemy : Enemy
{
    public double ATKBOOST = 0;
}

class BunkerEnemy : Enemy
{
    public double HPBOOST = 0;
}

class UnderworldEnemy : Enemy
{
    public int MAGICATK = 0;
    public double MAGICBOOST = 0;
}

public class EnemyManager
{
    
    public static void enemyManager()
    {
        OverworldEnemy Pirate = new OverworldEnemy();
        Pirate.HP = 140;
        Pirate.ATK = 45;
        Pirate.ATKBOOST = 1.2;
        Pirate.ATK *= (int)Pirate.ATKBOOST;
        Pirate.Disc = "A filthy thief from a foreign land here to overthrow the balance.";

        OverworldEnemy Traitor = new OverworldEnemy();
        Traitor.HP = 160;
        Traitor.ATK = 30;
        Traitor.ATKBOOST = 1.09;
        Traitor.ATK *= (int)Traitor.ATKBOOST;
        Traitor.Disc = "One who left one's land to find shelter in the pirates, cut the traitor off.";

        BunkerEnemy Robot = new BunkerEnemy();
        Robot.HP = 320;
        Robot.HPBOOST = 1.4;
        Robot.HP *= (int)Robot.HPBOOST;
        Robot.ATK = 55;
        Robot.Disc = "A simple robot created by ones in the bunker, don't let it fool ya it is pretty tanky";

        BunkerEnemy Drone = new BunkerEnemy();
        Drone.HP = 350;
        Drone.HPBOOST = 1.1;
        Drone.HP *= (int)Drone.HPBOOST;
        Drone.ATK = 65;
        Drone.Disc =
            "A swift enemy approaches is it a bird, is it a plane, no its the new R54 and it's here to stop you";

        UnderworldEnemy Demon = new UnderworldEnemy();
        Demon.HP = 670;
        Demon.ATK = 95;
        Demon.MAGICATK = 130;
        Demon.MAGICBOOST = 1;
        Demon.Disc = "You fell to hell itself, now meet it's most cliche entity, the demon.";

        UnderworldEnemy Underling = new UnderworldEnemy();
        Underling.HP = 750;
        Underling.ATK = 110;
        Underling.MAGICATK = 110;
        Underling.MAGICBOOST = 1.3;
        Underling.MAGICATK *= (int)Underling.MAGICBOOST;
        Underling.Disc =
            "An underling of the one who sent you here in the first place, being corrupt and evil it has a great thirst for your blood.";

    }

}