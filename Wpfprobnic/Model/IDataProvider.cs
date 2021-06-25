using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMed.Model
{
    interface IDataProvider
    {
        IEnumerable<Book> GetYear();
        IEnumerable<Book> GetYearA();
       
    }
}
