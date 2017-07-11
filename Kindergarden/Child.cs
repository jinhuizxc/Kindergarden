using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    // 小朋友
    class Child
    {
        public string name; // 姓名
        public int age; // 年龄
        public int height; // 身高
        // 封装快捷键：选中属性，点击鼠标右键进行重构
        private string sex = "男"; // 性别
        // 格式化代码：选中代码段：CTRL + K,CTRL + F
        public string Name
        {
            get
            {
                return name; // 读
            }
            set
            {
                name = value;
            } // 写
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            // 多行注释及取消注释ctrl + k/c,k/u
            //set
            //{
            //    sex = value;
            //}
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if(value >= 3&&value <= 7)
                age = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        // 调用带参方法
        public void EatSugar(string sugar) {
            if (sugar == "榴莲糖")
                Console.WriteLine("哎呀，最怕这个味道了");
            else
                Console.WriteLine("哈哈，是我喜欢的味道");
        }
        // 同类，多个方法名字相同参数不同
        public void EatSugar(int count)
        {
            if (count > 3)
                Console.WriteLine("吃糖太多对牙齿不好！");
            else
                Console.WriteLine("吃吧！");
        }
        

      

        // 踢足球
        public void PlayBall() {
            Console.WriteLine("耶！我是小小C罗！");
        }

        public void EatSugar1(int Age)
        {
            if (Age < 4) {
                Console.WriteLine("年龄太小，不能吃糖");
                return;// 结束方法调用
            }
            Console.WriteLine("我喜欢吃糖");
        }

        // 求和
        public int Add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;
        }
        // 无参构造
        public Child()
        {
            Name = "周杰伦";
        }
        // 带参构造方法
        public Child(string _name, string _sex, int _age)
        {
            name = _name;
            sex = _sex;
            age = _age;
        }
    }
}
