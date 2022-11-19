namespace GameSystem
{

    class MainClass
    {
        static void Main(string[] args)
        {
            WeaponManager.sort();
            EnemyManager.enemyManager();
            ArmorManager.select();
            PlayerStats.PlayerRun();
        }
    }
}