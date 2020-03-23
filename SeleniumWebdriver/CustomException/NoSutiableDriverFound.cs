using System;

namespace SeleniumWebdriver.CustomException
{
    public class NoSutiableDriverFound : Exception
    {
        public NoSutiableDriverFound(string msg) : base(msg)
        {

        }
    }
}
