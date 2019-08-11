using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Name: Sayda Rahman
 *   ID: 301042327
 *   
 * This program is about to purchase the computer from Dollar Computers store.
 * Created on: August 22, 2019.
 * Last modified on: August 09, 2019.
 */
namespace COMP123_Assignment5_Sayda_301042327.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the BackButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is event handler for the CancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the FinishButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Thanks for your purchase from Dollar Computer." + "\n\n" +
                "Your order will be processed in 7-10 business days.",
                "Order Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the  OrderForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the  Exit_Tool_StripMenu_Item exit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Tool_StripMenu_Item_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the OrderForm activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            Condition_Label.Text = Program.product.condition;
            //PriceDataLabel.Text = ((decimal)Program.product.cost).ToString("C");
            Plataform_Label.Text = Program.product.platform;
            OSD_Label.Text = Program.product.OS;
            Manufacturer_Label.Text = Program.product.manufacturer;
            Model_Label.Text = Program.product.model;
            Memory_Label.Text = Program.product.RAM_size;
            LCDSize_Label.Text = Program.product.screensize;
            HDD_Label.Text = Program.product.HDD_size;
            CPUBrand_Label.Text = Program.product.CPU_brand;
            CPUNumber_Label.Text = Program.product.CPU_number;
            GPUType_Label.Text = Program.product.GPU_Type;
            CPUType_Label.Text = Program.product.CPU_type;
            CPUSpeed_Label.Text = Program.product.CPU_speed;
            WebCam_Label.Text = Program.product.webcam;

            Price_Label.Text = "$" + Program.product.cost.ToString();
            SalesTax_Label.Text = "$" + (Program.product.cost * 13 / 100).ToString();
            TotalPrice_Label.Text = "$" + (Program.product.cost * 113 / 100).ToString();
        }
        /// <summary>
        /// This is the event handler for the AboutToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AboutToolStrip_MenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        
    }
}
