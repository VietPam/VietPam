using Builder.Models;

namespace Builder.Builders;
public class FoundAtBuilder
{
    private readonly List<FoundAt> _list;

    public FoundAtBuilder()
    {
        _list = new List<FoundAt>();
    }
    public IReadOnlyCollection<FoundAt> Get()
    {
        return _list.AsReadOnly();
    }

    public FoundAtBuilder Portfolio(string reference)
    {
        _list.Add(FoundAt.Porfolio(reference));
        return this;
    }

    public FoundAtBuilder LinkedIn(string reference)
    {
        _list.Add(FoundAt.LinkedIn(reference));
        return this;
    }
}
