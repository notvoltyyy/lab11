using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class GiftFactory
{
    public abstract EdibleGift CreateEdibleGift();
    public abstract NonEdibleGift CreateNonEdibleGift();

}
public class GoodGiftFactory : GiftFactory
{
    public override EdibleGift CreateEdibleGift()
    {
        return new Candy();
    }
    public override NonEdibleGift CreateNonEdibleGift()
    {
        return new Toy();
    }
}
public class BadGiftFactory : GiftFactory
{
    public override EdibleGift CreateEdibleGift()
    {
        return new BitterPill();
    }
    public override NonEdibleGift CreateNonEdibleGift()
    {
        return new Birch();
    }
}
public abstract class EdibleGift
{
    public abstract string Name { get; }
}
public abstract class NonEdibleGift
{
    public abstract string Name { get; }
}
public class Candy : EdibleGift
{
    public override string Name => "Candy";
}
public class Toy : NonEdibleGift
{
    public override string Name => "Toy";
}
public class BitterPill : EdibleGift
{
    public override string Name => "Bitter Pill";
}
public class Birch : NonEdibleGift
{
    public override string Name => "Birch";
}
