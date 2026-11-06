namespace ChainOfResponsibility.LogProcessor
{
    public class DebugLogProcessor : LogProcessor
    {
        public DebugLogProcessor(LogProcessor? logProcessor) : base(logProcessor)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if (logLevel == Debug)
            {
                Console.WriteLine("DEBUG:" + message);
            }
            else
            {
                if (next != null)
                {
                    next.Log(logLevel, message);
                }
            }
        }
    }
}
