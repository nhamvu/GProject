using GProject.Data.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GProject.WebApplication.Models
{
    public class SizeDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Status { get; set; } = 1; // 0: không sử dụng || 1: sử dụng
        public List<Size>? SizeList { get; set; }
    }
}
