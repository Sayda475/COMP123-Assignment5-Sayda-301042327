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
 * ID: 301042327
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

        //public object SelectedProductTextBox { get; private set; }
        //public object ProductsDataGridView { get; private set; }
        //public object ProductFields { get; private set; }

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
            var _columnCount = ProductDataGridView.ColumnCount;

            // CurrentRow.Selected = true;
            string outputString = string.Empty;

            for(int index = 0; index < _columnCount; index++)
            {
                outputString = outputString + _cells[index].Value + "";
            }

            SelectionTextBox.Text = outputString;

            NextButton.Enabled = true;

        }

        

    }
}
