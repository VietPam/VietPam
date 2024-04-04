namespace Builder.Models;
public record ProgrammingLanguage(string Name)
{
    public static readonly ProgrammingLanguage CSharp = new("C#");
    public static readonly ProgrammingLanguage TypeScript = new("TypeScript");
    public static readonly ProgrammingLanguage Dart = new("Dart");
}