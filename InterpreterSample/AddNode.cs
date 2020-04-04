using System;
namespace InterpreterSample
{
    /// <summary>
    /// And结点类，充当非终结符表达式角色
    /// </summary>
    public class AddNode:AbstractNode
    {
        public AddNode()
        {
        }

        private AbstractNode left;  //And的左表达式
        private AbstractNode right; //And的右表达式
        

        public AddNode(AbstractNode left,AbstractNode right)
        {
            this.left = left;
            this.right = right;
        }

        //And表达式解释操作
        public override string Interpret()
        {
            return left.Interpret() + "再" + right.Interpret();
        }
    }
}
