namespace GameSystem;

abstract public class Weapon
{
    public int ATK = 0;
    public string Disc = "";
    public int MagicDMG = 0;
    public int ProjectileDMG = 0;
    public double PhysicalBonus = 0;
}

class WeaponHolder : Weapon
{
    
}

public class atkWeapon : Weapon
{
    
}

public class magicWeapon : Weapon
{
    
}

public class projectileWeapon : Weapon
{
    
}

public class WeaponManager
{
    public static atkWeapon sharkM = new atkWeapon();
    public static magicWeapon mageShooter = new magicWeapon();
    public static projectileWeapon bombersDream = new projectileWeapon();
    public static void sort()
    {
        // SHARKM
        sharkM.ATK = 34;
        sharkM.PhysicalBonus = 1.352;
        sharkM.ATK = Convert.ToInt32(sharkM.ATK *sharkM.PhysicalBonus);
        sharkM.Disc =
            "A strong short weapon filled with physical power, excels at ridding you of overworldy bugs";

        // MAGESHOOTER
        mageShooter.ATK = 67;
        mageShooter.MagicDMG = 23;
        mageShooter.Disc =
            "A great weapon made by the ancient sages, great for getting rid of pesky demons";

        // BOMBERSDREAM
        bombersDream.ATK = 45;
        bombersDream.ProjectileDMG = 32;
        bombersDream.Disc = 
            "For pyromaniacs, terrorists or anyone with an explosive obsession, great for getting rid of bunker obstacles";
    

    }
}

public class WeaponStats
{
    public static Weapon selectedWeapon = new WeaponHolder();
    private static int weaponChoice = 0;
    public static Weapon select()
    {
        Console.WriteLine("Choose the weapon of your choice 1)SharkM 2)SageShooter 3)BombersDream");
        weaponChoice = Convert.ToInt32(Console.ReadLine());

        switch (weaponChoice)
        {
            case 1:
                selectedWeapon.ATK = WeaponManager.sharkM.ATK;
                selectedWeapon.PhysicalBonus = WeaponManager.sharkM.PhysicalBonus;
                selectedWeapon.Disc = WeaponManager.sharkM.Disc;
                break;
            case 2 :
                selectedWeapon.ATK = WeaponManager.mageShooter.ATK;
                selectedWeapon.MagicDMG = WeaponManager.mageShooter.MagicDMG;
                selectedWeapon.Disc = WeaponManager.mageShooter.Disc;
                break;
            case 3:
                selectedWeapon.ATK = WeaponManager.bombersDream.ATK;
                selectedWeapon.ProjectileDMG = WeaponManager.bombersDream.ProjectileDMG;
                selectedWeapon.Disc = WeaponManager.bombersDream.Disc;
                break;
            
        }
        
        return selectedWeapon;
    } 
}
