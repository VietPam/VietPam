﻿using Builder.Builders;
using Builder.Models.Enums;
namespace Builder.Models;
public class Developer
{
    private const int LifeTicks = int.MaxValue;
    private const double LifeChances = LifeTicks * 0.998;
    private static readonly Random _lifeRandomicity = new Random();

    private Developer()
    {
        ProgrammingLanguages = Array.Empty<ProgrammingLanguage>();
        Interests = Array.Empty<Interest>();
        FoundAt = Array.Empty<FoundAt>();
    }

    public bool IsWorking { get; private set; }
    public Musician MusicianInfo { get; private set; }
    public CountryYearStamp Born { get; private set; }
    public CountryYearStamp Lives { get; private set; }

    public IReadOnlyCollection<ProgrammingLanguage> ProgrammingLanguages { get; private set; }
    public IReadOnlyCollection<Interest> Interests { get; set; }
    public IReadOnlyCollection<FoundAt> FoundAt { get; set; }
    public bool HasLife { get; private set; }

    public static Developer Employed()
    {
        return new Developer
        {
            IsWorking = true,
            HasLife = true
        };
    }

    public static Developer Unemployed()
    {
        return new Developer
        {
            IsWorking = false,
            HasLife = true
        };
    }

    public Developer Musician(string instrument, Level level)
    {
        MusicianInfo = new Musician(instrument, level);
        return this;
    }

    public Developer BornIn(Cities city, int year)
    {
        Born = new CountryYearStamp(city, year);
        return this;
    }

    public Developer LivesIn(Cities city, int since)
    {
        Lives = new CountryYearStamp(city, since);
        return this;
    }

    public Developer CodesIn(Func<CodeLanguageSetBuilder, CodeLanguageSetBuilder> languages)
    {
        var builder = new CodeLanguageSetBuilder();
        languages(builder);
        ProgrammingLanguages = builder.Get();
        return this;
    }

    public Developer Interested(Func<InterestSetBuilder, InterestSetBuilder> @in)
    {
        var builder = new InterestSetBuilder();
        @in(builder);
        Interests = builder.Get();
        return this;
    }

    public Developer Found(Func<FoundAtBuilder, FoundAtBuilder> at)
    {
        var builder = new FoundAtBuilder();
        at(builder);
        FoundAt = builder.Get();
        return this;
    }

    public void LookForAGirlFriend() { DetermineAlive(); }
    public void EnjoyLife() { DetermineAlive(); }
    public void Code() { DetermineAlive(); }

    private void DetermineAlive()
    {
        int chance = _lifeRandomicity.Next(0, LifeTicks);
        if (chance > LifeChances)
        {
            HasLife = false; // 👻
        }
    }
}