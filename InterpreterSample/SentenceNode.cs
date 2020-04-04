using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterSample
{
    /// <summary>
    /// 简单句子结点类，充当非终结符表达式角色
    /// </summary>
    class SentenceNode:AbstractNode
    {
        private AbstractNode direction;
        private AbstractNode action;
        private AbstractNode distance;

        public SentenceNode(AbstractNode direction,AbstractNode action ,AbstractNode distance)
        {
            this.direction = direction;
            this.action = action;
            this.distance = distance;
        }

        //简单句子的解释操作
        public override string Interpret()
        {
            return direction.Interpret() + action.Interpret() + distance.Interpret();
        }
    }
}
