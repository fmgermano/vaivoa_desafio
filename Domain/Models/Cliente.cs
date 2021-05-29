using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vvef.Domain.Models 
{

    public class Cliente

    {
     
      public int Id {get ; set ; }
      
      public string Email {get; set;}

      public IList<Card> Cards {get; set;} = new List<Card>();

      
  }
}