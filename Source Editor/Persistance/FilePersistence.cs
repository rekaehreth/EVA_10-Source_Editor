using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Source_Editor.Persistance
{
    class FilePersistence
    {
        public string FilePath { set; get; }
        public async Task SaveAsync( string content, string path )
        {
            try
            {
                StreamWriter sw = new StreamWriter(path);
                await sw.WriteAsync(content);
                sw.Close();
            }
            catch (Exception)
            {
                throw new FileOperationException();
            }
        }
        public async Task<string> LoadAsync(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string result = await sr.ReadToEndAsync();
                sr.Close();
                return result;
            }
            catch (Exception)
            {
                throw new FileOperationException();
            }
        }
    }
}
