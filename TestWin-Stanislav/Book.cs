using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWin_Stanislav
{
    internal class Book
    {
        private string autor;
        private string title;
        private string izdatelstvo;
        private string janr;
        private string korica;
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Title
        { get { return title; } set { title = value; } }
        public string Janr
        { get { return izdatelstvo; } set { izdatelstvo = value; } }
        public string Korica
        { get { return korica; } set { korica = value; } }
        public Book(string autor, string title,string izdatelstvo,string janr,string korica)
        {
            this.autor = autor;
            this.title = title;
            this.izdatelstvo = izdatelstvo;
            this.janr = janr;
            this.korica = korica;
        }
    }
}
