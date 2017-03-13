namespace AbstractFactoryPattern
{
    public abstract class Creature : ICreature
    {
        protected Creature(string name)
        {
            _name = name;
        }

        public string DoMove()
        {
            return _name + ": " + _doMove.DoMove();
        }

        public abstract void MakeCreature();

        public string MakeSound()
        {
            return _name + ": " + _makeSound.MakeSound();
        }

        protected IDoMove _doMove;
        protected IMakeSound _makeSound;
        private string _name;

    }
}
