using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAsync1
{
    public partial class RecipeView : Form
    {
        private Form1 parentForm;
        private List<string[]> tableList;
        private bool[] stateMFCs;
        
        public RecipeView(Form1 parentFormIn, List<string[]> inputTable, bool[] stateMFCsIn)
        {
            InitializeComponent();
            parentForm = parentFormIn;
            tableList = inputTable;
            stateMFCs = stateMFCsIn;

            parentForm.DisableViewFlowBtn();

        }

        private void RecipeView_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;

            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = Settings1.Default.MFCcontrol_numMFCs+1;
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = System.Drawing.Color.Beige;
            columnHeaderStyle.Font = new System.Drawing.Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridView1.Columns[0].Name = "Time (min)";
            dataGridView1.Columns[1].Name = "MFC1";
            dataGridView1.Columns[2].Name = "MFC2";
            dataGridView1.Columns[3].Name = "MFC3";
            dataGridView1.Columns[4].Name = "MFC4";
            
            
            
            LoadValuesDataGridView(tableList);
        }

        private void RecipeView_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.EnableViewFlowBtn();
        }

        public void LoadValuesDataGridView(List<string[]> inputList_s)
        {
            foreach (string[] rowArray in inputList_s)
            {
                //loop over MFCs and convert Volts to sccm
                //for (int i = 1; i < stateM; i++)
                //{
                //    if (
                //}
                dataGridView1.Rows.Add(rowArray);
            }

        }



    }
}
