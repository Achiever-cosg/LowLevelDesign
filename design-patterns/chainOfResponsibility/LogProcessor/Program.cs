namespace ChainOfResponsibility.LogProcessor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LogProcessor logProcessor = new InfoLogProcessor(new DebugLogProcessor(new ErrorLogProcessor(null)));
            logProcessor.Log(0, "log the incoming request");
            logProcessor.Log(1, "debug the payload to extract payment data");
            logProcessor.Log(2, "error handle null pointer exception");
            logProcessor.Log(3, "error handle null pointer exception");
        }
    }
}
