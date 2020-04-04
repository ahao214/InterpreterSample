using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterSample
{
    /// <summary>
    /// 方向结点类，充当终结符表达式角色
    /// </summary>
    class DirectionNode:AbstractNode
    {
        private string direction;
        public DirectionNode(string direction)
        {
            this.direction = direction;
        }

        //方向表达式的解释操作
        public override string Interpret()
        {
            if(direction.Equals("up"))
            {
                return "向上";
            }
            else if(direction.Equals ("down"))
            {
                return "向下";
            }
            else if(direction.Equals("lefe"))
            {
                return "向左";
            }
            else if(direction.Equals("right"))
            {
                return "向右";
            }
            else
            {
                return "无效指令";
            }





        }

    }
}
