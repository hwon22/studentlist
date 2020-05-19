using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentlist
{
    class Program
    {
        class Teacher
        {
            public String name;
            public String subject;
        }
        static void Main(string[] args)
        {
            List<Teacher> list = new List<Teacher>();
            list.Add(new Teacher() { name = "서화원", subject = "소프트웨어과" });
            list.Add(new Teacher() { name = "이동욱", subject = "존잘" });
            list.Add(new Teacher() { name = "함기훈", subject = "씨샵" });
            list.Add(new Teacher() { name = "민주리", subject = "데이터베이스" });
            list.Add(new Teacher() { name = "이호연", subject = "수학" });
            list.Add(new Teacher() { name = "박성래", subject = "수학" });
            for (var i = list.Count - 1; i >= 0; i++)
            {
                if (list[i].subject == "데이터베이스")
                {
                    list.RemoveAt(i);
                }
            }
            /*
            foreach(var item in list)
            {
                if (item.subject == "데이터베이스")
                {
                    list.RemoveAt(item);
                }
                //Console.Write(item.name+":"+item.subject);
            }
            */
            foreach (var item in list)
            {
                Console.Write(item.name + ":" + item.subject);
            }
        }
    }
}