using System;

namespace BlazorApp3.Server
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException() : base("Object not found")
        {
        }
    }
}
