using System;
namespace FileData
{
    [Serializable]
    public class InvalidArgumentException : Exception
    {
        public InvalidArgumentException() { }

        public InvalidArgumentException(string args)
            : base(String.Format("Invalid argument : {0}", args))
        {

        }
    }
}
