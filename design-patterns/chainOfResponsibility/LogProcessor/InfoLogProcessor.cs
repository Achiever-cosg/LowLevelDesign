namespace ChainOfResponsibility.LogProcessor
{
    public class InfoLogProcessor : LogProcessor
    {
        public InfoLogProcessor(LogProcessor? logProcessor) : base(logProcessor)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if (logLevel == Info)
            {
                Console.WriteLine("INFO:" + message);
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
