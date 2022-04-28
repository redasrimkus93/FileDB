using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagement
{
    internal class FileService
    {
        private readonly FileContex _contex = new FileContex();
        public void WriteFilesToDb(string path)
        {
            var files = Directory.GetFiles(path);

            foreach (var item in files)
            {
                var file = new File();
                file.Name = Path.GetFileNameWithoutExtension(item);
                file.Path = item;
                file.Size = new FileInfo(item).Length;

                _contex.Files.Add(file);
                _contex.SaveChanges();
            }
        }
    }
}
