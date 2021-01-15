using System;

namespace Source_Editor.Model
{
    public class FileOperationEventArgs : EventArgs
    {
        string path;
        string fileContents;
    }
}