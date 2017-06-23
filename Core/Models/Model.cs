using System.ComponentModel.DataAnnotations;

namespace Vega.Core.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public virtual Make Make { get; set; }
        public int MakeId { get; set; }

    }
}
