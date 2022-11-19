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

        Console.WriteLine($"The player has an attack of {Player.ATK}, defense of {Player.DEF}, Magic damage of {Player.MAGICDMG}, projectile damage of {Player.PROJECTILEDMG}, current weapon is {WeaponStats.selectedWeapon.Name} it's description is {WeaponStats.selectedWeapon.Disc}");

        armorStats.ArmorS();
        Player.DEF += armorStats.selectedArmor.DEF;
        Player.ATK = Convert.ToInt32(Player.ATK*armorStats.selectedArmor.ATKBONUS);
        Player.MAGICDMG = Convert.ToInt32(Player.MAGICDMG*armorStats.selectedArmor.MAGICBONUS);
        Player.PROJECTILEDMG = Convert.ToInt32(Player.PROJECTILEDMG*armorStats.selectedArmor.PROJECTILEBONUS);

        Console.WriteLine($"The player has an attack of {Player.ATK}, defense of {Player.DEF}, Magic damage of {Player.MAGICDMG}, projectile damage of {Player.PROJECTILEDMG}, current armor is {armorStats.selectedArmor.Name} it's description is {armorStats.selectedArmor.Disc}");
    }
}