﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace database2.Models
{
    public class Book
    {
        [DisplayName("รหัสหนังสือ")]
        public int Id { get; set; }
        [DisplayName("ชื่อหนังสือ")]
        [DisplayFormat(NullDisplayText ="ไม่มี")]
        [Required(ErrorMessage ="ต้องระบุชื่อหนังสือ")]
        public string Name { get; set; }
        [DisplayName("ราคาหนังสือ")]
        [DisplayFormat(DataFormatString = "{0:C4}")]
        [Range(1,1000, ErrorMessage = "ราคาต้องอยู่ระหว่าง {1} กับ {2}")]
        [Required(ErrorMessage = "ต้องระบุราคาหนังสือ")]
        public decimal Price { get; set; }
        [DisplayName("ประเภทหนังสือ")]
        public BookType BookType { get; set; }
    }

    public enum BookType
    {
        [Display(Name = "ฟรี")]
        Free,
        [Display(Name = "จ่ายเงิน!!")]
        Paid
    }
}
