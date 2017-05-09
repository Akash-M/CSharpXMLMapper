using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLPositionMapper
{
    public partial class PositionMapper : Form
    {
        private static string mappingFilePath;

        public PositionMapper()
        {
            InitializeComponent();
        }

        public static string getMappingFilePath()
        {
            return mappingFilePath;            
        }

        public static void setMappingFilePath(string path)
        {
            mappingFilePath = path;            
        }

        private void selectResultXMLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.selectedResultXMLFilePathLabel.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void selectMappingXMLButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.mappingXMLFilePathLabel.Text = openFileDialog1.FileName;
                    setMappingFilePath(this.mappingXMLFilePathLabel.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void processXMLFileButton_Click(object sender, EventArgs e)
        {
            this.processXMLFile(this.selectedResultXMLFilePathLabel.Text);
        }

        private void processXMLFile(string destPath)
        {
            this.populateBalanceSheetDataGridViews(destPath);
            this.populateCashFlowDataGridViews(destPath);
            this.populateProfitAndLossGridViews(destPath);
            this.xmlFileProcessStatusLabel.Text = "Processing Completed..";
        }

        private void populateBalanceSheetDataGridViews(string destPath)
        {
            balanceSheetDataGridView.Columns.Clear();
            balanceSheetDataGridView.Columns.Add("Unprocessed_Positions", "Unprocessed Positions");
            balanceSheetDataGridView.Columns.Add("Map_to_Position", "Existing Positions");

            List<string> datasource = ResultXMLProcess.getBalanceSheetPositionsList();

            foreach (var position in ResultXMLProcess.loadUnprocessedBalanceSheetPositions(destPath))
            {
                DataGridViewRow RowSample = new DataGridViewRow();
                DataGridViewComboBoxCell CellSample = new DataGridViewComboBoxCell();
                CellSample.DataSource = datasource; // list of the string items that I want to insert in ComboBox
                CellSample.Value = datasource[0]; // default value for the ComboBox
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = position; // creating the text cell
                RowSample.Cells.Add(cell);
                RowSample.Cells.Add(CellSample);
                balanceSheetDataGridView.Rows.Add(RowSample);
            }

            // set width of first column
            DataGridViewColumn column1 = balanceSheetDataGridView.Columns[0];
            column1.Width = 400;
            DataGridViewColumn column2 = balanceSheetDataGridView.Columns[1];
            column2.Width = 400;
        }

        private void populateCashFlowDataGridViews(string destPath)
        {
            cashFlowDataGridView.Columns.Clear();
            cashFlowDataGridView.Columns.Add("Unprocessed_Positions", "Unprocessed Positions");
            cashFlowDataGridView.Columns.Add("Map_to_Position", "Existing Positions");

            List<string> datasource = ResultXMLProcess.getCashFlowPositionsList();

            foreach (var position in ResultXMLProcess.loadUnprocessedCashFlowPositions(destPath))
            {
                DataGridViewRow RowSample = new DataGridViewRow();
                DataGridViewComboBoxCell CellSample = new DataGridViewComboBoxCell();
                CellSample.DataSource = datasource; // list of the string items that I want to insert in ComboBox
                CellSample.Value = datasource[0]; // default value for the ComboBox
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = position; // creating the text cell
                RowSample.Cells.Add(cell);
                RowSample.Cells.Add(CellSample);
                cashFlowDataGridView.Rows.Add(RowSample);
            }

            // set width of first column
            DataGridViewColumn column1 = cashFlowDataGridView.Columns[0];
            column1.Width = 400;
            DataGridViewColumn column2 = cashFlowDataGridView.Columns[1];
            column2.Width = 400;
        }

        private void populateProfitAndLossGridViews(string destPath)
        {
            profitAndLossDataGridView.Columns.Clear();
            profitAndLossDataGridView.Columns.Add("Unprocessed_Positions", "Unprocessed Positions");
            profitAndLossDataGridView.Columns.Add("Map_to_Position", "Existing Positions");

            List<string> datasource = ResultXMLProcess.getProfitAndLossPositionsList();

            foreach (var position in ResultXMLProcess.loadUnprocessedProfitAndLossPositions(destPath))
            {
                DataGridViewRow RowSample = new DataGridViewRow();
                DataGridViewComboBoxCell CellSample = new DataGridViewComboBoxCell();
                CellSample.DataSource = datasource; // list of the string items that I want to insert in ComboBox
                CellSample.Value = datasource[0]; // default value for the ComboBox
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = position; // creating the text cell
                RowSample.Cells.Add(cell);
                RowSample.Cells.Add(CellSample);
                profitAndLossDataGridView.Rows.Add(RowSample);
            }

            // set width of first column
            DataGridViewColumn column1 = profitAndLossDataGridView.Columns[0];
            column1.Width = 400;
            DataGridViewColumn column2 = profitAndLossDataGridView.Columns[1];
            column2.Width = 400;
        }

        private void updateMappingFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                ResultXMLProcess.updateMappedBalanceSheetPositions(this.balanceSheetDataGridView);
                ResultXMLProcess.updateMappedCashFlowPositions(this.cashFlowDataGridView);
                ResultXMLProcess.updateMappedProfitAndLossPositions(this.profitAndLossDataGridView);
                this.mappingFileUpdateStatusLabel.Text = "Mapping file update succesfully";
            }
            catch (Exception ex)
            {
                this.mappingFileUpdateStatusLabel.Text = "Error occured while updating mapping file" + ex.Message;
            }
        }
        
    }
}
