using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorClient.Shared
{
    public class FormModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is required")]
        public string Text { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Must select one")]
        public int Select { get; set; }

        public FormModel() { }
    }
}
