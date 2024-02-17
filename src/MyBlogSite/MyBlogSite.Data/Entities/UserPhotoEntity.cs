using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogSite.Data.Entities
{
    public class UserPhotoEntity //  Kullanıcı fotoğraflarını saklamak için
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PhotoId { get; set; }

        [Required, MinLength(1), MaxLength(25)]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Upload)]
        [RegularExpression(@"\.(jpg|png|jpeg|gif)$", ErrorMessage= "Lütfen geçerli bir resim dosyası yükleyin")]
        public byte[] ImageData { get; set; } = null!;
    }
}
