using System;
using System.Numerics;

// Interface cho tướng
interface IChampion
{
    int Speed { get; }
    int walk();
}

// Lớp cơ sở cho tướng
class Yasuo : IChampion
{
    public Yasuo(int speed)
    {
        Speed = speed;
    }

    public int Speed { get; set; }
    public int walk()
    {
        return Speed;
    }
}
class Yone : IChampion
{
    public Yone(int speed)
    {
        Speed = speed;
    }
    public int Speed { get; set; }
     public int walk()
    {

        return Speed;
    }
}

// Lớp Decorator cho SummonerSpell
abstract class ChampionEffectDecorator : IChampion
{
    protected IChampion champion;
    public ChampionEffectDecorator(IChampion champion)
    {
        this.champion = champion;
    }
    public virtual int Speed { get; set; }

    public virtual int walk()
    {
        return champion.walk();
    }
}

// Lớp Decorator cho Teleport SummonerSpell
class GhostEffectDecorator : ChampionEffectDecorator
{
    public GhostEffectDecorator(IChampion champion) : base(champion)
    {
    }

    // Thêm tính năng bổ sung cho SummonerSpell

    public override int walk()
    {
        return base.walk() + 30;
    }
}

class ExhaustEffectDecorator : ChampionEffectDecorator
{
    public ExhaustEffectDecorator(IChampion champion) : base(champion)
    {
    }

    public override int walk()
    {
        return base.walk() - 10;
    }
}
class Program
{
    static void Main(string[] args)
    {

        // Tạo ra tướng 
        IChampion yasuo = new Yasuo(50);
        Console.WriteLine("Normal speed: " + yasuo.walk());

        // Thêm tính năng 
        IChampion yasuoWithGhost = new GhostEffectDecorator(yasuo);
        Console.WriteLine("Speed with ghost: " + yasuoWithGhost.walk());

        IChampion yasuoWithTeleportFlash = new ExhaustEffectDecorator(
                                           new GhostEffectDecorator(yasuo));
        Console.WriteLine("Speed with exhaust: " + yasuoWithTeleportFlash.walk());

        //IChampion yasuoWithExhaust = new ExhaustSpellDecorator(yasuo);
        //Console.WriteLine("Speed with exhaust: " + yasuoWithExhaust.walk());
    }
}
