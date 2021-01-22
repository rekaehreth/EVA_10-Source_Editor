using System;

namespace Source_Editor.Model
{
    public class FileOperationEventArgs : EventArgs
    {
        public string path;
        public string fileContents;
        public bool IsDirty;
        public FileOperationEventArgs(string path, string fileContents, bool isDirty)
        {
            this.path = path;
            this.fileContents = fileContents;
            IsDirty = isDirty;
        }
    }
}