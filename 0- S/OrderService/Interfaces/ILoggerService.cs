﻿namespace SOLID.S.OrderService.Interfaces
{
    public interface ILoggerService
    {
        void Info(string info);
        void Debug(string info);
        void Error(string message, Exception ex);
    }
}
