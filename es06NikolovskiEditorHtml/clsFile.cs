using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace es06NikolovskiEditorHtml
{
    public class clsFile
    {
        //campi privati
        private string fileName;
        private bool modificato;
        //property
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
            }
        }
        public bool Modificato
        {
            get
            {
                return modificato;
            }
            set
            {
                modificato = value;
            }
        }
        //costruttore
        public clsFile()
        {
            FileName = "";
            Modificato = false;
        }
        //metodi privati
        private string leggiFile()
        {
            string testo = "";
            if (FileName != "")
            {
                StreamReader sr = new StreamReader(FileName);
                testo = sr.ReadToEnd();
                sr.Close();
                Modificato = false;
            }
            return testo;
        }
    }
}
