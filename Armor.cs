namespace GameSystem;

abstract class armor
{
    public int DEF = 0;
    public string Disc = "";
    public double ATKBONUS = 0;
    public double MAGICBONUS = 0;
    public double PROJECTILEBONUS = 0;
}

class plainArmor : armor
{

}

class magicArmor : armor
{

}

class atkArmor : armor
{

}

class projectileArmor : armor
{

}

public class ArmorManager
{
    public static void select()
    {

        plainArmor sheild = new plainArmor();
        sheild.DEF = 34;
        sheild.Disc = "A normal armor, perfect for starters, don't get attached though.";

        magicArmor sagesCloak = new magicArmor();
        sagesCloak.DEF = 82;
        sagesCloak.MAGICBONUS = 1.5;
        sagesCloak.Disc = "Once used as a way to beat the demons, now used by you for what you wish to do";

        atkArmor sharkA = new atkArmor();
        sharkA.DEF = 45;
        sharkA.ATKBONUS = 1.2;
        sharkA.Disc =
            "Shark gils fill you with the strength of the shark king, some say this shield withdrew wars and glories";

        projectileArmor bulletProofVest = new projectileArmor();
        bulletProofVest.DEF = 63;
        bulletProofVest.PROJECTILEBONUS = 1.4;
        bulletProofVest.Disc =
            "Best way to fend off the shards of those pesky bots, made of material that can withstand a meteor's force";
    }
}