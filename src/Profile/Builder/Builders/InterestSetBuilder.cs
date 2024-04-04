using Builder.Models;

namespace Builder.Builders;
public class InterestSetBuilder
{
    private readonly List<Interest> _list;

    public InterestSetBuilder()
    {
        _list = new List<Interest>();
    }
    public IReadOnlyCollection<Interest> Get()
    {
        return _list.AsReadOnly();
    }

    public InterestSetBuilder Backend_DotNet()
    {
        _list.Add(new Interest(".NET 6/7/8"));
        return this;
    }

    public InterestSetBuilder Frontend_ReactJS()
    {
        _list.Add(new Interest("ReactJS Vite TailwindCss"));
        return this;
    }

    public InterestSetBuilder Mobile_Flutter()
    {
        _list.Add(new Interest("Flutter"));
        return this;
    }
}
