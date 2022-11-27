using System;
using System.Collections.Generic;

namespace p01
{
    class pro
    {
        static void Main(string[] args)
        {
            List<stu> list = new stu().stulist();
            stu estu = list.Find((stu) => stu.No == 1001);
            estu.No = 1007;
            list.RemoveAt(2);
            stu fstu = list.Find((stu) => stu.No == 1002);
            fstu.pIn();
            foreach (var stu in list)
            {
                stu.pIn();
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace p01
{
    public class stu
    {
        private int no;
        private String name;
        public stu() { }
        public stu(int no, String name)
        {
            this.no = no;
            this.name = name;
        }
        public int No
        {
            set { this.no = value; }
            get { return this.no; }
        }
        public List<stu> stulist()
        {
            stu stu1 = new stu(1, "h");
            stu stu2 = new stu(2, "e");
            stu stu3 = new stu(3, "l");
            stu stu4 = new stu(4, "l");
            stu stu5 = new stu(5, "o");
            List<stu> list = new List<stu>();
            list.Add(stu1);
            list.Add(stu2);
            list.Add(stu3);
            return list;
        }
        public String Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public void pIn()
        {
            Console.WriteLine(this.no + "," + this.name);
        }
    }
}




