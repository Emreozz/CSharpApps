namespace ConsoleApp1
{
    public interface IAnimal
    {
        string Name { get; }
        string Kind { get; }

        void GiveMoreInfo();
    }
}