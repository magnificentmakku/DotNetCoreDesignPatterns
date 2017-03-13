namespace AbstractFactoryPattern
{
    public abstract class CreatureFactory
    {
        public ICreature MakeCreature(string creatureType, string name)
        {
            Creature creature = CreateTheCreature(creatureType, name);
            creature.MakeCreature();
            return creature;
        }

        protected abstract Creature CreateTheCreature(string creatureType, string name);
    }
}
