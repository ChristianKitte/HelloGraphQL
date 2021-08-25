using System.ComponentModel.DataAnnotations;

namespace HelloGraphQL.Models
{
    public class Link
    {
        [Key] public int Link_ID { get; set; }
        [Required] public string Link_Url { get; set; }
        public string Link_Desription { get; set; }
        [Required]
        public int LinkGroup_ID { get; set; }
        public LinkGroup LinkGroup { get; set; }
    }
}