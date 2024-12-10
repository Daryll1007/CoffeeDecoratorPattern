public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "Coffee is the best drink one can have in the morning.";
    }
}
