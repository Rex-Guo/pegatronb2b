﻿using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace pegatronb2b.Web.Models
{
    //Please Register DbSet in DbContext.cs
    //public DbSet<RoleMenu> RoleMenus { get; set; }
    //public Entity.DbSet<RoleMenu> RoleMenus { get; set; }
     public partial class RoleMenu:Entity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        [Required]
        [Index("IX_rolemenu", 1, IsUnique = true)]
        public string RoleName { get; set; }

       
        
        [Index("IX_rolemenu", 2, IsUnique = true)]
        public int MenuId { get; set; }

        [ForeignKey("MenuId")]
        public MenuItem MenuItem { get; set; }

        public bool IsEnabled { get; set; }

        public bool Create { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }

        public bool Import { get; set; }
        public bool Export { get; set; }
    }
}