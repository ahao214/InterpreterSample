using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterSample
{
    /// <summary>
    /// 动作结点类，充当终结符表达式角色
    /// </summary>
    class ActionNode:AbstractNode
    {
        private string action;
        public ActionNode (string action)
        {
            this.action = action;
        }

        //动作（移动方式）表达式的解释操作
        public override string Interpret()
        {
            if (action.Equals("move"))
            {
                return "移动";
            }
            else if(action.Equals ("run"))
            {
                return "快速移动";
            }
            else
            {
                return "无效指令";
            }
        }





    }
}
