//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Sandbox
{
   public partial class Blog
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public Blog()
      {
         Posts = new System.Collections.Generic.HashSet<Post>();

         Init();
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      /// <summary>
      /// Max length = 256
      /// </summary>
      [MaxLength(256)]
      public string Url { get; set; }

      // Persistent navigation properties

      public virtual ICollection<Post> Posts { get; set; } 
   }
}
