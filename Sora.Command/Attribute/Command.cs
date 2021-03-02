using System;
using Sora.Command.Enumeration;

namespace Sora.Command.Attribute
{
    /// <summary>
    /// 指令
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public abstract class Command : System.Attribute
    {
        #region 属性

        /// <summary>
        /// 指令表达式
        /// </summary>
        internal string CommandExpression { get; }

        /// <summary>
        /// 指令描述
        /// </summary>
        internal string Description { get; }

        /// <summary>
        /// 匹配类型
        /// </summary>
        internal MatchType MatchType { get; }

        #endregion

        /// <summary>
        /// 构造方法
        /// </summary>
        protected Command(string command, MatchType matchType, string desc = "")
        {
            CommandExpression = command;
            Description       = desc;
            MatchType         = matchType;
        }
    }
}