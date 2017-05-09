namespace XMLPositionMapper
{
    partial class PositionMapper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.positionMappingGroupBox = new System.Windows.Forms.GroupBox();
            this.selectResultXMLButton = new System.Windows.Forms.Button();
            this.selectMappingXMLButton = new System.Windows.Forms.Button();
            this.selectedResultXMLFilePathLabel = new System.Windows.Forms.Label();
            this.mappingXMLFilePathLabel = new System.Windows.Forms.Label();
            this.processXMLFileButton = new System.Windows.Forms.Button();
            this.xmlFileProcessStatusLabel = new System.Windows.Forms.Label();
            this.unprocessedBalanceSheetPositionsGroupBox = new System.Windows.Forms.GroupBox();
            this.balanceSheetDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cashFlowDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.profitAndLossDataGridView = new System.Windows.Forms.DataGridView();
            this.mappingFileUpdateStatusLabel = new System.Windows.Forms.Label();
            this.updateMappingFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.positionMappingGroupBox.SuspendLayout();
            this.unprocessedBalanceSheetPositionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balanceSheetDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profitAndLossDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // positionMappingGroupBox
            // 
            this.positionMappingGroupBox.Controls.Add(this.mappingFileUpdateStatusLabel);
            this.positionMappingGroupBox.Controls.Add(this.updateMappingFileButton);
            this.positionMappingGroupBox.Controls.Add(this.groupBox2);
            this.positionMappingGroupBox.Controls.Add(this.groupBox1);
            this.positionMappingGroupBox.Controls.Add(this.unprocessedBalanceSheetPositionsGroupBox);
            this.positionMappingGroupBox.Controls.Add(this.xmlFileProcessStatusLabel);
            this.positionMappingGroupBox.Controls.Add(this.processXMLFileButton);
            this.positionMappingGroupBox.Controls.Add(this.mappingXMLFilePathLabel);
            this.positionMappingGroupBox.Controls.Add(this.selectedResultXMLFilePathLabel);
            this.positionMappingGroupBox.Controls.Add(this.selectMappingXMLButton);
            this.positionMappingGroupBox.Controls.Add(this.selectResultXMLButton);
            this.positionMappingGroupBox.Location = new System.Drawing.Point(13, 13);
            this.positionMappingGroupBox.Name = "positionMappingGroupBox";
            this.positionMappingGroupBox.Size = new System.Drawing.Size(1161, 958);
            this.positionMappingGroupBox.TabIndex = 0;
            this.positionMappingGroupBox.TabStop = false;
            this.positionMappingGroupBox.Text = "Map Positions";
            // 
            // selectResultXMLButton
            // 
            this.selectResultXMLButton.Location = new System.Drawing.Point(6, 32);
            this.selectResultXMLButton.Name = "selectResultXMLButton";
            this.selectResultXMLButton.Size = new System.Drawing.Size(211, 46);
            this.selectResultXMLButton.TabIndex = 0;
            this.selectResultXMLButton.Text = "Select Result XML File";
            this.selectResultXMLButton.UseVisualStyleBackColor = true;
            this.selectResultXMLButton.Click += new System.EventHandler(this.selectResultXMLButton_Click);
            // 
            // selectMappingXMLButton
            // 
            this.selectMappingXMLButton.Location = new System.Drawing.Point(6, 91);
            this.selectMappingXMLButton.Name = "selectMappingXMLButton";
            this.selectMappingXMLButton.Size = new System.Drawing.Size(211, 46);
            this.selectMappingXMLButton.TabIndex = 1;
            this.selectMappingXMLButton.Text = "Select Mapping XML File";
            this.selectMappingXMLButton.UseVisualStyleBackColor = true;
            this.selectMappingXMLButton.Click += new System.EventHandler(this.selectMappingXMLButton_Click);
            // 
            // selectedResultXMLFilePathLabel
            // 
            this.selectedResultXMLFilePathLabel.AutoSize = true;
            this.selectedResultXMLFilePathLabel.Location = new System.Drawing.Point(269, 47);
            this.selectedResultXMLFilePathLabel.Name = "selectedResultXMLFilePathLabel";
            this.selectedResultXMLFilePathLabel.Size = new System.Drawing.Size(111, 17);
            this.selectedResultXMLFilePathLabel.TabIndex = 2;
            this.selectedResultXMLFilePathLabel.Text = "No File Selected";
            // 
            // mappingXMLFilePathLabel
            // 
            this.mappingXMLFilePathLabel.AutoSize = true;
            this.mappingXMLFilePathLabel.Location = new System.Drawing.Point(269, 106);
            this.mappingXMLFilePathLabel.Name = "mappingXMLFilePathLabel";
            this.mappingXMLFilePathLabel.Size = new System.Drawing.Size(111, 17);
            this.mappingXMLFilePathLabel.TabIndex = 3;
            this.mappingXMLFilePathLabel.Text = "No File Selected";
            // 
            // processXMLFileButton
            // 
            this.processXMLFileButton.BackColor = System.Drawing.Color.OliveDrab;
            this.processXMLFileButton.Location = new System.Drawing.Point(6, 147);
            this.processXMLFileButton.Name = "processXMLFileButton";
            this.processXMLFileButton.Size = new System.Drawing.Size(211, 46);
            this.processXMLFileButton.TabIndex = 4;
            this.processXMLFileButton.Text = "Process XML File";
            this.processXMLFileButton.UseVisualStyleBackColor = false;
            this.processXMLFileButton.Click += new System.EventHandler(this.processXMLFileButton_Click);
            // 
            // xmlFileProcessStatusLabel
            // 
            this.xmlFileProcessStatusLabel.AutoSize = true;
            this.xmlFileProcessStatusLabel.Location = new System.Drawing.Point(272, 158);
            this.xmlFileProcessStatusLabel.Name = "xmlFileProcessStatusLabel";
            this.xmlFileProcessStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.xmlFileProcessStatusLabel.TabIndex = 5;
            // 
            // unprocessedBalanceSheetPositionsGroupBox
            // 
            this.unprocessedBalanceSheetPositionsGroupBox.Controls.Add(this.balanceSheetDataGridView);
            this.unprocessedBalanceSheetPositionsGroupBox.Location = new System.Drawing.Point(6, 207);
            this.unprocessedBalanceSheetPositionsGroupBox.Name = "unprocessedBalanceSheetPositionsGroupBox";
            this.unprocessedBalanceSheetPositionsGroupBox.Size = new System.Drawing.Size(1146, 236);
            this.unprocessedBalanceSheetPositionsGroupBox.TabIndex = 6;
            this.unprocessedBalanceSheetPositionsGroupBox.TabStop = false;
            this.unprocessedBalanceSheetPositionsGroupBox.Text = "Unprocessed Balance Sheet Positions";
            // 
            // balanceSheetDataGridView
            // 
            this.balanceSheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceSheetDataGridView.Location = new System.Drawing.Point(7, 20);
            this.balanceSheetDataGridView.Name = "balanceSheetDataGridView";
            this.balanceSheetDataGridView.RowTemplate.Height = 24;
            this.balanceSheetDataGridView.Size = new System.Drawing.Size(1133, 208);
            this.balanceSheetDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cashFlowDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(6, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 236);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unprocessed Cash Flow Positions";
            // 
            // cashFlowDataGridView
            // 
            this.cashFlowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashFlowDataGridView.Location = new System.Drawing.Point(7, 20);
            this.cashFlowDataGridView.Name = "cashFlowDataGridView";
            this.cashFlowDataGridView.RowTemplate.Height = 24;
            this.cashFlowDataGridView.Size = new System.Drawing.Size(1133, 208);
            this.cashFlowDataGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.profitAndLossDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(6, 702);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1146, 236);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unprocessed Profit and Loss Positions";
            // 
            // profitAndLossDataGridView
            // 
            this.profitAndLossDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profitAndLossDataGridView.Location = new System.Drawing.Point(7, 20);
            this.profitAndLossDataGridView.Name = "profitAndLossDataGridView";
            this.profitAndLossDataGridView.RowTemplate.Height = 24;
            this.profitAndLossDataGridView.Size = new System.Drawing.Size(1133, 208);
            this.profitAndLossDataGridView.TabIndex = 0;
            // 
            // mappingFileUpdateStatusLabel
            // 
            this.mappingFileUpdateStatusLabel.AutoSize = true;
            this.mappingFileUpdateStatusLabel.Location = new System.Drawing.Point(911, 162);
            this.mappingFileUpdateStatusLabel.Name = "mappingFileUpdateStatusLabel";
            this.mappingFileUpdateStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.mappingFileUpdateStatusLabel.TabIndex = 10;
            // 
            // updateMappingFileButton
            // 
            this.updateMappingFileButton.Location = new System.Drawing.Point(648, 147);
            this.updateMappingFileButton.Name = "updateMappingFileButton";
            this.updateMappingFileButton.Size = new System.Drawing.Size(211, 46);
            this.updateMappingFileButton.TabIndex = 9;
            this.updateMappingFileButton.Text = "Update Mapping File";
            this.updateMappingFileButton.UseVisualStyleBackColor = true;
            this.updateMappingFileButton.Click += new System.EventHandler(this.updateMappingFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PositionMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 963);
            this.Controls.Add(this.positionMappingGroupBox);
            this.Name = "PositionMapper";
            this.Text = "PositionMapper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.positionMappingGroupBox.ResumeLayout(false);
            this.positionMappingGroupBox.PerformLayout();
            this.unprocessedBalanceSheetPositionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.balanceSheetDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashFlowDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profitAndLossDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox positionMappingGroupBox;
        private System.Windows.Forms.Button selectResultXMLButton;
        private System.Windows.Forms.Button selectMappingXMLButton;
        private System.Windows.Forms.Label mappingXMLFilePathLabel;
        private System.Windows.Forms.Label selectedResultXMLFilePathLabel;
        private System.Windows.Forms.Button processXMLFileButton;
        private System.Windows.Forms.Label xmlFileProcessStatusLabel;
        private System.Windows.Forms.GroupBox unprocessedBalanceSheetPositionsGroupBox;
        private System.Windows.Forms.DataGridView balanceSheetDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView cashFlowDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView profitAndLossDataGridView;
        private System.Windows.Forms.Label mappingFileUpdateStatusLabel;
        private System.Windows.Forms.Button updateMappingFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}