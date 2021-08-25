using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HelloGraphQL.Models
{
    public class LinkGroup
    {
        [Key] public int LinkGroup_ID { get; set; }
        [Required] public string LinkGroup_Name { get; set; }
        public string LinkGroup_Description { get; set; }
        public ICollection<Link> LinkGroup_Links { get; set; } = new List<Link>();
    }
}