namespace Builder.Models;
public record FoundAt(string Local, string Reference)
{
    public static FoundAt Porfolio(string reference) => new("Porfolio", reference);
    public static FoundAt LinkedIn(string reference) => new("LinkedIn", reference);
}
