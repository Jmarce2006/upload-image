using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FileExtensionsAttribute = UploadImage.Validators.FileExtensionsAttribute;
namespace UploadImage.Models
{
    public partial class Images
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        [DataType(DataType.Upload)]
        [FileExtensions("jpg,jpeg,png", ErrorMessage = "El archivo tiene que tener una de estas extensiones: jpg,jpeg,png")]
        public byte[] ImageData { get; set; }
    }
}
