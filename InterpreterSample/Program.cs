using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterSample
{
    /// <summary>
    /// 解释器模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string instruction = "down run 10 and left move 20";
            InstructionHandler handler = new InstructionHandler();
            handler.Handle(instruction);

            string outString;
            outString = handler.Output();
            Console.WriteLine(outString);
            Console.ReadLine();

        }
    }
}
