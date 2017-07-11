using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    // 将class改成struct(结构),可以定义字段，属性，方法
    struct Dog
    {
        string _name; // 结构中不能实例属性或字段初始值设定项

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        // 无参构造方法,结构不能包含显式的无参数构造函数
        //public Dog() { }
        // 有参构造,不会报错（在控制返回调用方之前，字段Dog._name必须完全赋值）
        public Dog(string name) {
            _name = name;
        }
        public void Sing()
        {
            Console.WriteLine("汪汪");
        }
    }
}
