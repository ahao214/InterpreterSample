using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterSample
{
    /// <summary>
    /// 距离结点类，充当终结符表达式角色
    /// </summary>
    class DistanceNode:AbstractNode
    {
        private string distance;
        public DistanceNode(string distance)
        {
            this.distance = distance;
        }

        //距离表达式的解释操作
        public override string Interpret()
        {
            return this.distance;
        }
    }
}
