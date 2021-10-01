using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    // properties, constructors, methods, etc. go here
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }
  }
}