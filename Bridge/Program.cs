// Implementor interface
public interface IEffect
{
    void ApplyEffect();
}

// Concrete Implementor classes
public class DamageEffect : IEffect
{
    public void ApplyEffect()
    {
        Console.WriteLine("Deals damage to the enemy.");
    }
}

public class HealEffect : IEffect
{
    public void ApplyEffect()
    {
        Console.WriteLine("Heals an ally.");
    }
}

// Abstraction class
public abstract class Skill
{
    protected IEffect _effect;

    public Skill(IEffect effect)
    {
        _effect = effect;
    }

    public abstract void Cast();
}

// Refined Abstraction classes
public class OffensiveSkill : Skill
{
    public OffensiveSkill(IEffect effect) : base(effect)
    {
    }

    public override void Cast()
    {
        Console.WriteLine("Cast an offensive skill.");
        _effect.ApplyEffect();
    }
}

public class SupportSkill : Skill
{
    public SupportSkill(IEffect effect) : base(effect)
    {
    }

    public override void Cast()
    {
        Console.WriteLine("Cast a supportive skill.");
        _effect.ApplyEffect();
    }
}

// Client code
public class Champion
{
    public OffensiveSkill OffensiveSkill { get; set; }
    public SupportSkill SupportSkill { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        Champion champion = new Champion();
        champion.OffensiveSkill = new OffensiveSkill(new DamageEffect());
        champion.SupportSkill = new SupportSkill(new HealEffect());

        champion.OffensiveSkill.Cast();
        champion.SupportSkill.Cast();
    }
}
