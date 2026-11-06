namespace ChainOfResponsibility.LogProcessor
{
    public class ErrorLogProcessor : LogProcessor
    {
        public ErrorLogProcessor(LogProcessor? logProcessor) : base(logProcessor)
        {
        }

        public override void Log(int logLevel, string message)
        {
            if (logLevel == Error)
            {
                Console.WriteLine("ERROR:" + message);
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
