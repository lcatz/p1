using System.Collections.Generic;


namespace PizzaBox.Domain.Models
{
  public class Store
  {
    public string Name { get; set; }

    public long StoreID { get; set; }

    public List<Order> Orders { get; set; }
  }
}
