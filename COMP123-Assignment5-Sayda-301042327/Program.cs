using COMP123_Assignment5_Sayda_301042327.Models;
using COMP123_Assignment5_Sayda_301042327.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Assignment5_Sayda_301042327
{
   public static class Program
    {
        //These are static members
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;

        public static Product product;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // instantiation of all forms
            splashScreen = new SplashScreen();
            startForm = new StartForm();
            selectForm = new SelectForm();  
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();
            product = new Product();


            Application.Run(splashScreen);
        }
    }
}
