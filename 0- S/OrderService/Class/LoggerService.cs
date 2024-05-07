using SOLID.S.OrderService.Interfaces;


namespace SOLID.S.OrderService.Class
{
    public class LoggerService : ILoggerService
    {
        public LoggerService()
        {

        }
        public void Debug(string info)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception ex)
        {
            throw new NotImplementedException();
        }

        public void Info(string info)
        {
            throw new NotImplementedException();
        }
    }
}
