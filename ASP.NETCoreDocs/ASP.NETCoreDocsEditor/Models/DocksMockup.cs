using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreDocsEditor.Models
{
    public class DocksMockup
    {
        //values for the document
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }


        //values for the user info
        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; }
    }
}
