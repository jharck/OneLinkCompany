using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneLinkCompany.Models
{
    public class Subarea
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubareaID { get; set; }
        public string Name { get; set; }

        public ICollection<Area> Areas { get; set; }
    }
}