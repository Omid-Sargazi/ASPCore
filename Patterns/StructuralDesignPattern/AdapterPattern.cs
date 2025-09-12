namespace Patterns.StructuralDesignPattern
{
    public interface ITarget
    {
        public string GetRequest();
    }

    public class Adapter : ITarget
    {
        private Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            _adaptee.GetOldRequest() + "Use Adapter for adaptee";
        }
    }

    public class Adaptee
    {
        public string GetOldRequest()
        {
            return "Old Request";
        }
    }
}