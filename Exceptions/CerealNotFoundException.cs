using System;

    // Custom exception for handling requests for cereals not found in database
    public class CerealNotFoundException : Exception
    {
        public CerealNotFoundException(string name)
            : base($"{name} not found in database") { }
    }
