namespace GameSixFriday
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;
        private static int _countpowerups;

        static Foe()
        {
            _countpowerups = 0;
        }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="name">Nome do Foe</param>
        public Foe(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0) health = 0;
            }
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string name)
        {
            name = name.Trim(' ');
            this.name = name;
        }

        public void PickupPowerUp(PowerUp powerup, float quantidade)
        {
            if(powerup == PowerUp.Health)
            {
                float antigoHP = this.health;
                this.health += quantidade;

                if(health > 100)
                    health = 100;
            }
            else if(powerup == PowerUp.Shield)
            {
                float antigoShield = this.shield;
                this.shield += quantidade;

                if(shield > 100)
                    shield = 100;
            }
            _countpowerups++;
        }

        public static int GetPickedPowerUps()
        {
            return _countpowerups;
        }
    }
}