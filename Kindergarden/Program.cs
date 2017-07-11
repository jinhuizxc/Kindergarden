using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kindergarden
{
    class Program
    {
        static Dog dog;
        static void Main(string[] args)
        {

            Child xiaoming = new Child();// 实例化Child类的对象
            xiaoming.Name = "马小明"; // 为字段赋值
            //xiaoming.Sex = "男";
            xiaoming.Age = 5;
            xiaoming.Age = 30;
            xiaoming.Height = 120;
            Console.WriteLine("我叫" + xiaoming.Name
                + ", 今年"
                + xiaoming.Age + "岁。");
            Console.WriteLine("我是一个小" + xiaoming.Sex + "孩");
            xiaoming.PlayBall();// 调用踢球的方法
            Child child = new Child();// 构造方法
            child.EatSugar("水果糖");// 实参
            child.EatSugar(5);
            child.EatSugar1(3);
            int sum;// 和
            sum = child.Add(3, 7);
            Console.WriteLine("两个数字的和是:" + sum);
            Console.WriteLine("名字是:{0}",child.Name);
            // 带参构造
            child = new Child("jh", "男", 25);
            Console.WriteLine("我的名字是{0}", child.Name);
            Console.WriteLine("我的性别是{0}", child.Sex);
            Console.WriteLine("我的年龄是{0}", child.Age);

            child = new Child() { name = "哈哈",height = 10};
            Console.WriteLine("我叫{0}，今年{1}岁！",
                child.Name, child.Height);

            //Dog dog = new Dog();
            dog.Name = "小白";
            dog.Sing();
            Console.WriteLine("我叫" + dog.Name);

            Student student1 = new Student("梁晓萌", Gender.女, 4);
            Student student2 = new Student("刘晓明", (Gender)1, 5);
            Console.WriteLine("我叫{0}，我是{1}生", student1.Name, student1.Sex);
            Console.WriteLine("我叫{0}，我是{1}生", student2.Name, student2.Sex);
            // 调用静态方法
            Growth(student1);// 按引用传参，方法修改形参，通常实参也会被修改
          /*  Growth(student1.Age);*/// 按值传参，方法修改形参，实参不会被修改
            Console.WriteLine("我现在{0}岁了！", student1.Age);
            // ref关键字不允许对象属性来传参，故用变量表示！
            int age = 3;
            Growth(ref age);
            Console.WriteLine("我现在{0}岁了！", age);

            int ly, ny;// 接收结果
            Growth(age, out ly, out ny);
            Console.WriteLine("我明年{0}岁,去年{1}岁！", ny, ly);
        }
        
        // 静态方法
        static void Growth(Student student)// 引用类型参数
        {
            student.Age++;
            Console.WriteLine("我又长大一岁!");
        }
        static void Growth(ref int age)// 值类型参数
        {
            age++;
            Console.WriteLine("噢耶，我又长大一岁!" + age);
        }

        // out关键字
        static void Growth(int age, out int lastYear, out int nextYear)
        {
            lastYear = age - 1;
            nextYear = age + 1;

        }
       
    }
}
