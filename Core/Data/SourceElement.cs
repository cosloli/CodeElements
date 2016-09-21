namespace CodeElements.Data
{
    /// <summary>
    /// 为源代码文件中的一个代码元素提供抽象数据基类。
    /// </summary>
    public abstract class SourceElement
    {
        /// <summary>
        /// 获取源代码文件的名称。
        /// </summary>
        public string SourceFileName { get; private set; }

        /// <summary>
        /// 获取该代码元素的名称。
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// 获取该代码元素在源代码文件中定义的位置（行号）。
        /// </summary>
        public int SourceLine { get; private set; }

        protected SourceElement(string sourceFileName, string name, int sourceLine)
        {
            SourceFileName = sourceFileName;
            Name = name;
            SourceLine = sourceLine;
        }
    }
}
