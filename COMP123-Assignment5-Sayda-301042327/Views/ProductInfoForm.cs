using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Name: Sayda Rahman
 *   ID: 301042327
 *   
 * This program is about to purchase the computer from Dollar Computers store.
 * Created on: August 22, 2019.
 * Last modified on: August 14, 2019.
 */
namespace COMP123_Assignment5_Sayda_301042327.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is event handler for the ClearButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the SelectAnotherOneButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherOneButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_FromClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            NextButton.Enabled = false;
        }
       
        /// <summary>
        /// This is the event handler for the ProductInfoForm Activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            CostDataLabel.Text = "$" + Program.product.cost.ToString();

            //Product info group box
            PlatformButton.Text = Program.product.platform;
            OSButton.Text = Program.product.OS;
            ManufacturerButton.Text = Program.product.manufacturer;
            ModelButton.Text = Program.product.model;
            WidthButton.Text = Program.product.width;
            HeightButton.Text = Program.product.height;
            WeightButton.Text = Program.product.weight;
            DepthButton.Text = Program.product.depth;
            PowerButton.Text = Program.product.power;
            WebcamButton.Text = Program.product.webcam;
            LANButton.Text = Program.product.LAN;
            WIFIButton.Text = Program.product.WIFI;

            // Tech spaces group box
            RAMSizeDataLabel.Text = Program.product.RAM_size;
            RAMTypeDataLabel.Text = Program.product.RAM_type;
            HDDDataLabel.Text = Program.product.HDD_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            WebCamDataLabel.Text = Program.product.webcam;

            NextButton.Enabled = true;

        }

        /// <summary>
        /// This is the event handler for the  exitToolStripMenuItem exit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// This is the event handler for the  openToolStripMenuItem exit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// This is the event handler for the  selectAnotherToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAnotherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

    }
}
