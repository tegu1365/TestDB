using System;
using TestDatabase.Models;
using TestDatabase.Services;

namespace TestDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            TestContext testContext = new TestContext();

            ProfileService _service = new ProfileService(testContext);

            string[] arg = "Asd asdf 1234 Admin".Split(" ");
            _service.AddProfile(arg);
        }
    }
}