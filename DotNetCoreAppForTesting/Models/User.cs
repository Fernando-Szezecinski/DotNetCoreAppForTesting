using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreAppForTesting.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }

        [RegularExpression(@"^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2})$|^(([0-2]\d|[3][0-1])\/([0]\d|[1][0-2])\/[2][0]\d{2}\s([0-1]\d|[2][0-3])\:[0-5]\d\:[0-5]\d)$", ErrorMessage = "Please use this format => dd/mm/yyyy")]
        public string Birthday  { get; set; }
        public bool Enabled { get; set; }
    }


}
