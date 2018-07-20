using System;
using System.Collections.Generic;
using System.Text;

namespace LightweightMapper
{
    public class A
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public C User { get; set; }

        /// <summary>
        /// 标注为notmapped特性时，不转换赋值
        /// </summary>
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public D UserA { get; set; }

    }

    public class B
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public D User { get; set; }
        public D UserA { get; set; }
    }

    public class C
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class D
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
