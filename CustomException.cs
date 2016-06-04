using System;
using System.Runtime.Serialization;

namespace CustomException
{
    public class CustomException
    {
        public static void Main(string[] args)
        {
            try
            {
                //You can use your own custom exceptions just like how you use other exception classes.
                throw new MyCustomException("CustomException occured.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    //CustomException may inherit from the base exception class so that you don't have to implement general exception methods yourself
    //Serialization is used when two different application is passing objects and/or communicating through a network
    [Serializable]
    public class MyCustomException : Exception
    {
        //Create constructors that points to base class constructors
        public MyCustomException() : base() { }

        public MyCustomException(string message) : base(message) { }

        public MyCustomException(string message, Exception innerException) : base(message, innerException) { }

        public MyCustomException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
