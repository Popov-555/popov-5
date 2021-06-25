using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMed.Model
{
    public class LocalDataProvider : IDataProvider
    {

        public IEnumerable<Book> GetYears()

        {
            return new Book[] {
                new Book{Name="Капитанская дочка",Avtor="А.С.Пушкин",Izdatelstvo="«Азбука»",
Year ="1836" ,Kolichestvo="500" },
                new Book { Name = "Пиковая дама", Avtor = "А.С.Пушкин", Izdatelstvo = "«Азбука»",
Year ="1834",Kolichestvo="300" },
                new Book { Name = "Герой нашего времени", Avtor = "Лермонтов.М.Ю",Izdatelstvo = "АСТ",
Year ="1840",Kolichestvo="400" },
            };
        }
        public IEnumerable<YearA> GetYearA()
        {
            return new YearA[] {
        new YearA{ Title="Все года " },
        new YearA{ Title="1840" },
        new YearA{ Title="1834" },
    };
        }

        public IEnumerable<Book> GetYear()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Book> IDataProvider.GetYearA()
        {
            throw new NotImplementedException();
        }
    }
}