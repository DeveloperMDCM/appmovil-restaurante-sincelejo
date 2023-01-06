using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://lavecindad.azurewebsites.net/images/noimage.png"
            : $"https://registrocomidas.blob.core.windows.net/products/{ImageId}";
    }
}
