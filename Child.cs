using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Child
{
    public string Name; 
    public int GoodDeeds; 
    public int BadDeeds; 
    public Child(string name, int goodDeeds, int badDeeds)
    {
        Name = name;
        GoodDeeds = goodDeeds;
        BadDeeds = badDeeds;

    }
    public void ReceiveGifts(EdibleGift edibleGift, NonEdibleGift nonEdibleGift)
    {
        Console.WriteLine($"{Name} gets: {edibleGift.Name},{nonEdibleGift.Name}");
    }

}
public class ChildIterator : IEnumerator
{
    private readonly Children _children;
    private int _index = -1;

    public ChildIterator(Children children)
    {
        _children = children;
    }

    object IEnumerator.Current => Current();
    public Child Current()
    {
        return _children.List[_index];
    }

    public bool HasNext()
    {
        return _index < _children.List.Count - 1;
    }

    public bool MoveNext()
    {
        if (!HasNext())
        {
            return false;
        }
        _index++;
        return true;
    }

    public void Reset()
    {
        _index = 0;
    }
}

public class Children : IEnumerable
{
    List<Child> list = new List<Child>();
    public List<Child> List { get { return list; } }
    public IEnumerator GetEnumerator()
    {
        return new ChildIterator(this);
    }
    public void Add(Child child)
    {
        list.Add(child);
    }
}