using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SaintNicholas
{
    private static SaintNicholas _instance;
    private Children children;

    private SaintNicholas()
    {
        children = new Children();
    }
    public static SaintNicholas Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SaintNicholas();
            }
            return _instance;
        }
    }
    public void AddChild(Child child)
    {
        children.Add(child);
    }
    public void SendGifts()
    {
        foreach (Child child in children)
        {
            GiftFactory factory;

            if (child.GoodDeeds >= child.BadDeeds)
            {
                factory = new GoodGiftFactory();
            }
            else
            {
                factory = new BadGiftFactory();
            }
            var edibleGift = factory.CreateEdibleGift();
            var nonEdibleGift = factory.CreateNonEdibleGift();
            child.ReceiveGifts(edibleGift, nonEdibleGift);
        }
    }
}