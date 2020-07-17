using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public interface ITest
    {
        string Path { get; }
    }

    public class Test : ITest
    {
        public string Path { get; }

        public Test(string path)
        {
            Path = path;
        }
    }
}
