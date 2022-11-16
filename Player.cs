namespace GameSystem;

static class Player
{
    public static int ATK = 10;
    public static int DEF = 5;
    public static int MAGICDMG = 0;
    public static int PROJECTILEDMG = 0;
    
}

public class PlayerStats
{
    public static void PlayerRun()
    {
        WeaponStats.select();
        Player.ATK += WeaponStats.selectedWeapon.ATK;
        Player.MAGICDMG += WeaponStats.selectedWeapon.MagicDMG;
        Player.PROJECTILEDMG += WeaponStats.selectedWeapon.ProjectileDMG;

        Console.WriteLine($"The player has an attack of {Player.ATK}, defense of {Player.DEF}, Magic damage of {Player.MAGICDMG}, projectile damage of {Player.PROJECTILEDMG}, current weapon description is {WeaponStats.selectedWeapon.Disc}");
    }
}