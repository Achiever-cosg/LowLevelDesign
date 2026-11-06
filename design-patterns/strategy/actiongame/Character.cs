namespace Strategy.ActionGame
{
    public class Character
    {
        private IWeaponBehaviour weaponBehaviour;

        public Character(IWeaponBehaviour behaviour)
        {
            this.weaponBehaviour = behaviour;
        }

        public void SetWeaponBehaviour(IWeaponBehaviour behaviour)
        {
            this.weaponBehaviour = behaviour;
        }

        public void Attack()
        {
            this.weaponBehaviour.UseWeapon();
        }
    }
}
