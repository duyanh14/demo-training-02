using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_t3
{

    public class Cat
    {
        private string name = String.Empty;
        private DateTime age;
        private int color;

        // Struct dùng để lưu trữ các dữ liệu, không yêu cầu kế thừa
        private struct Parent
        {
            public string dad = string.Empty;
            public string mom = string.Empty;

            public Parent()
            {
            }
        }

        private Parent parent = new Parent();

        public Cat(string name, DateTime age, int color) 
        {
            this.name = name;
            this.age = age; 
            this.color = color; 
        }

        public void setParent(string dad, string mom)
        {
            this.parent.dad = dad;
            this.parent.mom = mom;
        }

        public void showInfo()
        {
            Console.WriteLine("Name = {0}, Age = {1}, Color = {2}",this.name, this.age,this.color);
            Console.WriteLine("Dad = {0}, Mom = {1}", this.parent.dad, this.parent.mom);
        }

    }
}
