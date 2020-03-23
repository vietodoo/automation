using System;

namespace SeleniumWebdriver.CustomException
{
    public class NoSuchKeywordFoundException : Exception
    {
        public NoSuchKeywordFoundException(string msg) : base(msg)
        {

        }
    }
}
