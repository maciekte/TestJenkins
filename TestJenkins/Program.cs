﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestJenkins
{
    [TestFixture]
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(createmessage());
        }
        public static string createmessage()
        {
            return "Hello World";
        }
        public void TestMethod()
        {
            Assert.AreEqual("Hello World", createmessage());
        }
    }
}
