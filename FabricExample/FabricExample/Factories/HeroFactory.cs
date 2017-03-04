namespace FabricExample.Factories
{
    public abstract class HeroFactory
    {
        protected HeroFactory()
        {
            
        }
        public abstract IMovement CreateMovement();
        public abstract IWeapon CreateWeapon();
    }

    //public interface IHeroFactory
    //{
    //    Movement CreateMovement();
    //    Weapon CreateWeapon();
    //}

}