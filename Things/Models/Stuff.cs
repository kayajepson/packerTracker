using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Stuff
  {
    public string Items {get; set;}
    public int Id {get; set;}
    public int Packed {get; set;}
    public int Amount {get; set;}
    private static List<Stuff> _instances = new List<Stuff> {};

    public Stuff (string items, int packed, int amount)
    {
      Items = items;
      Packed = packed;
      Amount = amount;
      _instances.Add(this);
      Id = _instances.Count;
    }


    public int GetId()
    {
      return Id;
    }

    public static List<Stuff> GetAll()
    {
      return _instances;
    }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    public static Stuff Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
