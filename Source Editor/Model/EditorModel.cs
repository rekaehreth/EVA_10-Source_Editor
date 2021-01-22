using Source_Editor.Persistance;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Source_Editor.Model
{
    class EditorModel
    {
        private string fileContents;
        private string fileName;
        private string filePath = null;
        FilePersistence filePersistence = new FilePersistence();
        public event EventHandler<FileOperationEventArgs> FileOpened;
        public event EventHandler<FileOperationEventArgs> FileSaved;
        public EditorModel( FilePersistence persistence )
        {
            filePersistence = persistence;
        }
        public bool pathAvailable()
        {
            return filePath != null && filePath != "";
        }
        public async Task SaveFileAsync(string contents, bool isDirty, string path = null)
        {
            await filePersistence.SaveAsync(contents, path);
            FileSaved?.Invoke(this, new FileOperationEventArgs(path, contents, isDirty));
        }
        internal void NewFile()
        {
            fileContents = null;
            fileName = null;
            filePath = null;
        }
        public async Task LoadFileAsync(string path, bool isDirty)
        {
            fileContents = await filePersistence.LoadAsync(path);
            FileOpened?.Invoke(this, new FileOperationEventArgs(path, fileContents, isDirty));
        }
    }
}
