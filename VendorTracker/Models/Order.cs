using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    // properties, constructors, methods, etc. go here
    private static List<Order> _instances = new List<Order> {};
    public string Name { get; set; }
    public int Id { get; set; }
    public List<Order> Orders { get; set; }

    public Order(string orderName)
    {
      Name = orderName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }

    public static void RemoveById(int id)
    {
      _instances.RemoveAt(id - 1);

      for (int index = 0; index < _instances.Count; index++)
          {
            _instances[index].Id = index + 1;
          }
    }  
  }
}