using GProject.Data.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace GProject.WebApplication.Models
{
    public class ColorDTO
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên Màu")]
        [StringLength(30, ErrorMessage = "Tên Màu không được vượt quá 30 kí tự")]
        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mã Màu")]
        [StringLength(20, ErrorMessage = "Mã Màu không được vượt quá 20 kí tự")]
        [DataMember(EmitDefaultValue = false)]
        public string HEXCode { get; set; }
        public int Status { get; set; } = 1; // 0: không sử dụng || 1: sử dụng

        [DataMember(EmitDefaultValue = false)]
        public List<Color>? ColorList { get; set; }
    }
}
