using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Source_Editor.Model
{
    class EditorModel
    {
        // A modell legyen alkalmas a fájl tartalmának tárolására, a fájl nevének és elérési útvonalának nyilvántartására! 
        // Az elérési útvonal alapértelmezetten legyen null, és 
        private string fileContents;
        private string fileName;
        private string filePath = null;
        public event EventHandler<FileOperationEventArgs> FileOpened;
        public event EventHandler<FileOperationEventArgs> FileSaved;
        // legyen egy publikus függvény annak lekérésére, hogy tartozik-e már elérési útvonal a fájlhoz!
        public bool pathAvailable()
        {
            return filePath == null;
        }
        // A modell tartalmazzon egy publikus aszinkron eljárást a mentéshez a fájl tartalmával és opcionálisan az elérési útvonallal, mint paraméterekkel!
        public async Task SaveFile(string contents, string path = null)
        {

        }
        // A modell tartalmazzon egy publikus aszinkron eljárást a betöltéshez, mely paraméterül kapja az elérési útvonalat!
        public async Task LoadFile(string path)
        {

        }
    }
}
