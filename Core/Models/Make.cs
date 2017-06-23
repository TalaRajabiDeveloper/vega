using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Vega.Core.Models
{
    public class Make
    {

        public Make()
        {
            this.Models = new Collection<Model>();
        }
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public virtual ICollection<Model> Models { get; set; }

    }
}
