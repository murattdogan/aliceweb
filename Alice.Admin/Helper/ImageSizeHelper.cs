using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;


namespace Alice.Admin.Helper
{
    public class ImageSizeHelper
    {
        public static string Resize(string randomFileName, IFormFile ImageFile, string size, int width, int height, string fileExtension)
        {

            var filePath = $"/var/www/console.luxuryistanbul.com/Content/UI/Image/{randomFileName}{Path.GetExtension(ImageFile.FileName)}";
            if (ImageFile != null && ImageFile.Length > 0)
            {
                var fileName = Path.GetFileName(ImageFile.FileName);
                using (var fileSteam = new FileStream(filePath, FileMode.Create))
                {
                    ImageFile.CopyTo(fileSteam);
                }
            }

            var newFilePath = $"/var/www/console.luxuryistanbul.com/Content/UI/Image/{size}/{randomFileName}{Path.GetExtension(ImageFile.FileName)}";
            using (Image<Rgba32> image = Image.Load(filePath))
            {
                image.Mutate(x => x
                     .Resize(width, height));
                image.Save(newFilePath);
            }

            return $"\\Content\\UI\\Image\\{size}";

        }
    }
}
