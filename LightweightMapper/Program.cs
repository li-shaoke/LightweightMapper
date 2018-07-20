using System;

namespace LightweightMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A
            {
                Id = 1,
                Name = "张三",
                User = new C
                {
                    Id = 1,
                    Name = "李四"
                }
            };
            B b = Mapper<A, B>.Map(a);
            Console.WriteLine(b.Id + "_" + b.Equals(a));

            A a2 = Mapper<A, A>.Map(a);

            Console.WriteLine(a2.Name + "_" + a2.Equals(a));

        }
    }
}
