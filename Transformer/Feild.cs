using Mutatio.ITransformer;

namespace Mutatio.Transformer
{
    public enum ACCESS { PUBLIC, PRIVATE, PROTECTD}

    public abstract class Feild : ITransformer.ITransformer
    {
        string _location;
        string _name;

        public Feild(string location, string name)
        {
            _location = location;
            _name = name;
        }
        
        public string getLocation()
        {
            return _location;
        }

        public string getName()
        {
            return _name;
        }

        public abstract void transfrom();
    }

    public class FeildAccessTransformer : Feild
    {
        ACCESS _old;
        ACCESS _new;

        public FeildAccessTransformer(string location, string name, ACCESS oldAccess, ACCESS newAcceess) : base(location, name)
        {
            _old = oldAccess;
            _new = newAcceess;
        }

        public ACCESS getOldAccess()
        {
            return _old;
        }

        public ACCESS getNewAccess()
        {
            return _new;
        }

        public override void transfrom()
        {
            throw new System.NotImplementedException();
        }
    }
}