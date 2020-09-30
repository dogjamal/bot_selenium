using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bot_selenium
{
    public partial class Form1 : Form
    {
        IWebDriver browser;
        int p_num = 0;

        private string Find_window(String url)
        {
            String start_window = browser.CurrentWindowHandle;
            String result = "";

            for (int i = 0; i < p_num; i++)
            {
                if (browser.WindowHandles[i] != start_window)
                {
                    browser.SwitchTo().Window(browser.WindowHandles[i]);
                    if (browser.Url.Contains(url))
                    {
                        result = browser.WindowHandles[i];
                        break;
                    }
                }
            }

            browser.SwitchTo().Window(start_window);
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Manage().Window.Maximize();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            IWebElement click_ob;
            IWebElement Search;
            string temp;


            browser.Navigate().GoToUrl("http://google.com");

            Search = browser.FindElement(By.Name("q"));
            Search.SendKeys("qa testing" + OpenQA.Selenium.Keys.Enter);

            // open "Картинки"
            click_ob = browser.FindElement(By.LinkText("Картинки"));
            click_ob.Click();

            // parsing and opening sites, which contain certain text
            for (int i = 1; i < 10; i++)
            {

                temp = browser.FindElement(By.CssSelector(".isv-r:nth-child(" + i + ") > .VFACy")).Text;

                click_ob = browser.FindElement(By.CssSelector(".isv-r:nth-child(" + i + ") > .VFACy"));
                if (temp.Contains("QA Testing"))
                {
                    click_ob.Click();
                    p_num++;
                    TextBox1.AppendText(temp + "\r\n");
                }
            }
        }

        private void Tab_Click(object sender, EventArgs e)
        {
            String g_window = Find_window("google");
            browser.SwitchTo().Window(g_window);
            System.Windows.Forms.MessageBox.Show(browser.Title + "\r\n" + browser.Url);
        }

        private void JS_Click(object sender, EventArgs e)
        {
            //    IJavaScriptExecutor jset = browser as IJavaScriptExecutor;
            //   jset.ExecuteScript("$(.F7UV7d).hide();");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            browser.Quit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
