using COMP123_Assignment5_Sayda_301042327.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        public object SelectedProductTextBox { get; private set; }
        public object ProductsDataGridView { get; private set; }
        public object ProductFields { get; private set; }

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
        /// This is event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the SelectForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the SelectForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            using(var db = new DollarComputerContext())
            {
                db.products.Load();
                productBindingSource.DataSource = db.products.Local.ToBindingList();
            }
            //Disable Next button until selection
            NextButton.Enabled = false;
        }
        /// <summary>
        /// This is the event handler for the ProductsDataGridView SelectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var _rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var _currentRow = ProductDataGridView.Rows[_rowIndex];
            var _cells = _currentRow.Cells;
            NextButton.Enabled = true;

            Program.product.productID = short.Parse(_cells[Product.PRODUCT_ID].Value.ToString());
            Program.product.cost = decimal.Parse(_cells[Product.COST].Value.ToString());
            Program.product.manufacturer = _cells[Product.MANUFACTURER].Value.ToString();
            Program.product.condition = _cells[Product.CONDITION].Value.ToString();
            Program.product.platform = _cells[Product.PLATFORM].Value.ToString();
            //Program.product.OS = _cells[index: (int)Product.OS].Value.ToString();
            Program.product.model = _cells[Product.MODEL].Value.ToString();
            Program.product.RAM_size = _cells[Product.RAM_SIZE].Value.ToString();
            Program.product.screensize = _cells[Product.SCREEN_SIZE].Value.ToString();
            Program.product.HDD_size = _cells[Product.HDD_SIZE].Value.ToString();
            Program.product.CPU_brand = _cells[Product.CPU_BRAND].Value.ToString();
            Program.product.CPU_number = _cells[Product.CPU_NUMBER].Value.ToString();
            Program.product.GPU_Type = _cells[Product.GPU_TYPE].Value.ToString();
            Program.product.CPU_type = _cells[Product.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = _cells[Product.CPU_SPEED].Value.ToString();
            Program.product.webcam = _cells[Product.WEBCAM].Value.ToString();


            SelectionTextBox.Text = Program.product.manufacturer.ToString() + " " +
                                         Program.product.model.ToString() + " " +
                                         ((decimal)Program.product.cost).ToString("C");

        }

        

    }
}
