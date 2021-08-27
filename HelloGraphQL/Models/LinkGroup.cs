using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using HotChocolate;

namespace HelloGraphQL.Models
{
    [GraphQLDescription("Stellt eine Gruppe von Links dar")]
    public class LinkGroup
    {
        [Key] public int LinkGroup_ID { get; set; }

        [GraphQLDescription("Der Name eine Gruppe von Links")]
        [Required]
        public string LinkGroup_Name { get; set; }

        [GraphQLDescription("Beschreibt den Inhalt der Gruppe")]
        public string LinkGroup_Description { get; set; }

        public ICollection<Link> LinkGroup_Links { get; set; } = new List<Link>();
    }
}