using System;
using System.Numerics;

// Interface cho tướng
interface IChampion
{
    string Name { get; }
    int AttackDamage { get; }
    string Cast();
}

// Lớp cơ sở cho tướng
class Yasuo : IChampion
{
    public Yasuo(int attackDamage)
    {
        Name = "Yasuo";
        AttackDamage = attackDamage;
    }

    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public string Cast()
    { 
        return "Yasuo cast: ";
    }
}
class Yone : IChampion
{
    public Yone(int attackDamage)
    {
        Name = "Yone";
        AttackDamage = attackDamage;
    }

    public string Name { get; set; }
    public int AttackDamage { get; set; }
    public string Cast()
    {
        return "Yone cast: ";
    }
}

// Lớp Decorator cho SummonerSpell
abstract class ChampionSpellDecorator : IChampion
{
    protected IChampion champion;
    public ChampionSpellDecorator(IChampion champion)
    {
        this.champion = champion;
    }

    public virtual string Name { get; set; }
    public virtual int AttackDamage { get; set; }

    public virtual string Cast()
    {
       return champion.Cast();
    }
}

// Lớp Decorator cho Teleport SummonerSpell
class TeleportSummonerSpellDecorator : ChampionSpellDecorator
{
    public TeleportSummonerSpellDecorator(IChampion champion) : base(champion)
    {
    }

    public override string Name
    {
        get
        {
            return champion.Name + " with Teleport Summoner Spell";
        }
        set { }
    }

    public override int AttackDamage
    {
        get
        {
            return champion.AttackDamage;
        }
        set { }
    }

    // Thêm tính năng bổ sung cho SummonerSpell
    public override string Cast()
    {
        return base.Cast() + " teleport,";
    }

}

class FlashSummonerSpellDecorator : ChampionSpellDecorator
{
    public FlashSummonerSpellDecorator(IChampion champion) : base(champion)
    {
    }

    public override string Name
    {
        get
        {
            return champion.Name + " with Flash Summoner Spell";
        }
        set { }
    }

    public override int AttackDamage
    {
        get
        {
            return champion.AttackDamage;
        }
        set { }
    }

    // Thêm tính năng bổ sung cho SummonerSpell
    public override string Cast()
    {
        return base.Cast() + " flash,";
    }

}
class Program
{
    static void Main(string[] args)
    {
        // Tạo ra tướng Ezreal
        IChampion yasuo = new Yasuo(50);
        Console.WriteLine(yasuo.Cast());


        // Thêm tính năng Teleport Summoner Spell
        IChampion yasuoWithTeleport = new TeleportSummonerSpellDecorator(yasuo);
        Console.WriteLine(yasuoWithTeleport.Cast());


        IChampion yone = new Yone(1);
        IChampion yoneWithTeleportFlash = new FlashSummonerSpellDecorator(
                                            new TeleportSummonerSpellDecorator(yone));
        Console.WriteLine(yoneWithTeleportFlash.Cast());
    }
}
