﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.DAL.ViewModels.Activity
{
    public class EditActivityViewModel
    {

        public int Id { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(350, ErrorMessage = "تعداد کاراکتر شده بیش از حد مجاز است")]
        public string Title { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(700, ErrorMessage = "تعداد کاراکتر شده بیش از حد مجاز است")]
        public string Description { get; set; }

        [Display(Name = "آیکون")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "تعداد کاراکتر شده بیش از حد مجاز است")]
        public string Icon { get; set; }
    }

    public enum EditActivityResult
    {
        Success,
        ActivityNotFound,
        Error
    }
}
