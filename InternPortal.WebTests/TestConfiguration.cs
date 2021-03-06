﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;

namespace InternPortal.WebTests
{
    public class TestConfiguration
    {
        public TestConfiguration()
        {

            //Driver = new InternetExplorerDriver();
            //Driver = new FirefoxDriver();

            Driver = new ChromeDriver();
            BaseUrl = "http://localhost:2178/";
            ScreenshotLocation = @"C:\Screenshots\InternPortal\";
            PageTimeOut = 20;
            TestStep = 1;
            TestDateTime = DateTime.Now;
        }

        public IWebDriver Driver { get; set; }
        public string BaseUrl { get; set; }
        public string ScreenshotLocation { get; set; }
        public int PageTimeOut { get; set; }
        public DateTime TestDateTime { get; set; }
        public int TestStep { get; set; }
    }
}