// using System.Collections.Generic;
// using System.Linq;


// namespace PizzaBox.Storing
// {
//   public class PizzaBoxRepository
//   {
//     private  PizzaBoxContext _ctx;

//     public PizzaBoxRepository(PizzaBoxContext context)
//     {
//       _ctx = context;
//     }

//     public List<string> GetStores()
//     {
//       return _ctx.Stores.Select(s => s.Name).ToList();
//     }

//     // public IEnumerable<long> Get<T>() where T : AModel
//     // {
//     //   return _ctx.Set<T>().Select(t => t.GetType().GetProperty()).ToList();
//     // }
//   }
// }
