using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using excel = Microsoft.Office.Interop.Excel;

namespace Selftest
{
    public class Utilities
    {
      
        public void readDataFromExcel()
        {
            //we opened applacation 
            excel.Application xlapplication = new excel.Application();
            //we are opening workbook 
            excel.Workbook xlworkbook = xlapplication.Workbooks.Open("");
            //we will open the worksheet 
            excel.Worksheet worksheet = xlworkbook.Sheets[1];
            excel.Range range = worksheet.UsedRange.Rows;

            int totalrows = range.Count;

            int username = 1;
            //int password = 2;
            string[] result = new string[30];
            for (int i = 2; i < range.Count; i++)
            {
                result[i] = range.Cells[username][i].value2;
                var ExceluserName = range.Cells[username][i].value2;
                Console.WriteLine(ExceluserName);
                //return ExceluserName;
            }

        }




        //string title;
        //IWebDriver driver;

        //public Utilities()
        //{
        //   GetTitle();
        //}

        //public String GetTitle()
        //{
        //    title = driver.Title;
        //    return title;

        //   // return driver.Title;
        //}
    }
}
