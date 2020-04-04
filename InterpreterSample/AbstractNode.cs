using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterSample
{
    /// <summary>
    /// 抽象结点类，充当抽象表达式角色
    /// </summary>
    abstract class AbstractNode
    {
        public abstract string Interpret();
    }
}
