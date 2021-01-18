using System;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : AModel
  {
    public Store Store { get; set; }

    public long StoreEntityID { get; set; }

    public DateTime DateModified { get; set; }
  }
}
