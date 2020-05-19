using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class MyBook
    {
        public string name;
        public DateTime date;
        public string author;
        public string publish;
        public string publisher;
        public string publisheditor;
        public string planner;
        public string editor;
        public string designer;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyBook book = new MyBook
            {
                name = "PHP 프로그래밍 입문",
                date = new DateTime(2013, 5, 20),
                author = "황재호",
                publish = "김태헌",
                publisher = "한빛아카데미(주)",
                publisheditor = "김현용",
                planner = "김이화",
                editor = "김이화",
                designer = "여동일"
            };
        }
    }
}
