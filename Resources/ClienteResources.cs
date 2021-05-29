using System.Collections.Generic;
using vvef.Domain.Models;

namespace vvef.Resources
{
    public class ClienteResource
    {
        public int Id { get; set; }
        public string Email { get; set; }
        
      public IList<Card> Cards {get; set;} = new List<Card>();
    }
}