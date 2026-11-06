namespace ChainOfResponsibility.LogProcessor
{
    public abstract class LogProcessor
    {
        public static int Debug = 1;
        public static int Info = 0;
        public static int Error = 2;

        protected LogProcessor? next;

        public LogProcessor(LogProcessor? next)
        {
            this.next = next;
        }

        public abstract void Log(int logLevel, string message);
    }
}
