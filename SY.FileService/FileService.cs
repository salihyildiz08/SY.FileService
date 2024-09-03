using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace SY.FileService
{
    public static class FileService
    {
        public static string FileSaveToServer(IFormFile file, string filePath)
        {
            string fileName = string.Join(".", DateTime.Now.ToFileTime().ToString(), file.FileName);
            string path = filePath + fileName;
            using (var stream = File.Create(path))
            {
                file.CopyTo(stream);
            }
            return fileName;
        }

        public static void FileDeleteToServer(string path)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
            }
            catch (Exception)
            {
            }
        }

    }
}
