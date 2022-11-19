namespace GameSystem;

abstract public class armor
{
    public int DEF = 0;
    public string Disc = "";
    public string Name = "";
    public double ATKBONUS = 1;
    public double MAGICBONUS = 1;
    public double PROJECTILEBONUS = 1;
}

class armorHolder : armor
{

}

public class plainArmor : armor
{

}

public class magicArmor : armor
{

}

public class atkArmor : armor
{

}

public class projectileArmor : armor
{

}

public class ArmorManager
{
    public static plainArmor sheild = new plainArmor();
    public static magicArmor sagesCloak = new magicArmor();
    public static atkArmor sharkA = new atkArmor();
    public static projectileArmor bulletProofVest = new projectileArmor();

    public static void select()
    {

        // SHEILD
        sheild.Name = "Sheild";
        sheild.DEF = 34;
        sheild.Disc = "A normal armor, perfect for starters, don't get attached though.";

        // SAGESCLOAK
        sagesCloak.Name = "Sage's Cloak";
        sagesCloak.DEF = 82;
        sagesCloak.MAGICBONUS = 1.5;
        sagesCloak.Disc = "Once used as a way to beat the demons, now used by you for what you wish to do";

        // SHARKA
        sharkA.Name = "SharkA";
        sharkA.DEF = 45;
        sharkA.ATKBONUS = 1.2;
        sharkA.Disc =
            "Shark gils fill you with the strength of the shark king, some say this shield withdrew wars and glories";

        // BULLETPROOFVEST
        bulletProofVest.Name = "BulletProofVest";
        bulletProofVest.DEF = 63;
        bulletProofVest.PROJECTILEBONUS = 1.4;
        bulletProofVest.Disc =
            "Best way to fend off the shards of those pesky bots, made of material that can withstand a meteor's force";
    }
}
    public class armorStats
    {
        public static armor selectedArmor = new armorHolder();
        private static int armorChoice = 0;
        public static armor ArmorS()
        {
            Console.WriteLine("\nChoose the armor of your choice 1)Shield 2)SagesCloak 3)SharkA 4)BulletProofVest");
            armorChoice = Convert.ToInt32(Console.ReadLine());

            switch (armorChoice) {

                case 1:
                    selectedArmor.Name = ArmorManager.sheild.Name;
                    selectedArmor.DEF = ArmorManager.sheild.DEF;
                    selectedArmor.Disc = ArmorManager.sheild.Disc;
                break;

                case 2:
                    selectedArmor.Name = ArmorManager.sagesCloak.Name;
                    selectedArmor.DEF = ArmorManager.sagesCloak.DEF;
                    selectedArmor.MAGICBONUS = ArmorManager.sagesCloak.MAGICBONUS;
                    selectedArmor.Disc = ArmorManager.sagesCloak.Disc;
                    break;

                case 3:
                    selectedArmor.Name = ArmorManager.sharkA.Name;
                    selectedArmor.DEF = ArmorManager.sharkA.DEF;
                    selectedArmor.ATKBONUS = ArmorManager.sharkA.ATKBONUS;
                    selectedArmor.Disc = ArmorManager.sharkA.Disc;
                    break;

                case 4:  
                    selectedArmor.Name = ArmorManager.bulletProofVest.Name;  
                    selectedArmor.DEF = ArmorManager.bulletProofVest.DEF;
                    selectedArmor.PROJECTILEBONUS = ArmorManager.bulletProofVest.PROJECTILEBONUS;
                    selectedArmor.Disc = ArmorManager.bulletProofVest.Disc;
                    break;

            }
                return selectedArmor;
        }
    }
