using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Person
    {
        private string name;
        private int age;

        public void setName(string name) {
            this.name = name;
        }

        public void setAge(int age) {
            this.age = age;
        }

        public string getName() {
            return name;
        }

        public int getAge() {
            return age;
        }

        public void print() {
            Console.WriteLine("{0} - {1}", getName(), getAge());
        }
    }
}
