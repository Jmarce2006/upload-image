using System;
using System.Collections.Generic;

namespace UploadImage.Models
{
    public partial class Images
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
    }
}
