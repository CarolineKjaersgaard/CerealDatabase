using System;

    // Custom exception for handling requests for cereals that already exists in database
    public class CerealFoundException : Exception
    {
        public CerealFoundException(string name)
            : base($"{name} already exists in database") { }
    }