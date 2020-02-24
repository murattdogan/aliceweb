using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;


namespace Alice.Admin.Helper
{
    public class ImageSizeHelper
    {
        public static string Resize(IHostingEnvironment _environment, string randomFileName, IFormFile ImageFile, string path, string size, int width, int height, string fileExtension)
        {

            using (var memoryStream = new MemoryStream())
            {
                ImageFile.CopyTo(memoryStream);
                using (var img = Image.FromStream(memoryStream))
                {
                    img.GetThumbnailImage(img.Width >= width ? width : img.Width, img.Height >= height ? height : img.Height, () => false, IntPtr.Zero).Save(Path.Combine(@"Content/UI/Image", size, $"{randomFileName}{fileExtension}"));
                    return $"{path}{size}";
                }
            }

        }
    }
}
