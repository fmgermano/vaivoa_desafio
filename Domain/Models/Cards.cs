using System.ComponentModel.DataAnnotations;

namespace vvef.Domain.Models
{

    public class Card
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}




