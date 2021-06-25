using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMed.Model
{
    public class Book
    {
        public string Name { get; set; }
        public string Avtor { get; set; }
        public string Izdatelstvo { get; set; }
        public string Year { get; set; }
        public string Kolichestvo { get; set; }
        public string Title { get; internal set; }
    }
}