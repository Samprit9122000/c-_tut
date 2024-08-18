using System;

namespace MyException
{
    public class CustomException : Exception
    {
        public CustomException(string ex) : base(ex) { }

    }