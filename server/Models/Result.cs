﻿namespace server.Models
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public String Message { get; set; }
        public T? Data { get; set; }

        public Result(bool success, String message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public Result(T data)
        {
            Success = true;
            Message = "Success";
            Data = data;
        }
    }
}
