﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreDocsEditor.Models
{
    public class DocksMockup
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [Required]
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; }
    }
}