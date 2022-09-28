namespace EjercitacionClase10
{
    public class Warrior
    {
        protected Weapon currentWeap;

        public void EquipWeapon(Weapon newWeapon)
        {
            this.currentWeap = newWeapon;
        }

        public string Attack()
        {
            return currentWeap.Attacking();
        }
    }
}