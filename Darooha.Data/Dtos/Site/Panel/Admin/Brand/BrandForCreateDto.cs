using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Darooha.Data.Dtos.Site.Panel.Admin.Brand
{
    public class BrandForCreateDto
    {
        [Required]
        [StringLength(100, MinimumLength = 0)]
        public string BrandName { get; set; }
        public IFormFile File { get; set; }
    }
}
