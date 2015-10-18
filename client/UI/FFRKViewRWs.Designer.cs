namespace FFRKInspector.UI
{
    partial class FFRKViewRWs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pchtFriendSB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pchtMutualSB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pchtFollowerSB = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewRWs = new FFRKInspector.UI.DataGridViewEx();
            this.dgcNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFriendCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pchtFriendSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pchtMutualSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pchtFollowerSB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRWs)).BeginInit();
            this.SuspendLayout();
            // 
            // pchtFriendSB
            // 
            chartArea1.Name = "ChartArea1";
            this.pchtFriendSB.ChartAreas.Add(chartArea1);
            legend1.Name = "Friends SBs";
            this.pchtFriendSB.Legends.Add(legend1);
            this.pchtFriendSB.Location = new System.Drawing.Point(473, 4);
            this.pchtFriendSB.Name = "pchtFriendSB";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Friends SBs";
            series1.Name = "Series1";
            series1.XValueMember = "FriendSeries.SBName";
            series1.YValueMembers = "FriendSeries.Count";
            this.pchtFriendSB.Series.Add(series1);
            this.pchtFriendSB.Size = new System.Drawing.Size(415, 285);
            this.pchtFriendSB.TabIndex = 1;
            this.pchtFriendSB.Text = "Friends";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Friends";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.pchtFriendSB.Titles.Add(title1);
            // 
            // pchtMutualSB
            // 
            chartArea2.Name = "ChartArea1";
            this.pchtMutualSB.ChartAreas.Add(chartArea2);
            legend2.Name = "Friends SBs";
            this.pchtMutualSB.Legends.Add(legend2);
            this.pchtMutualSB.Location = new System.Drawing.Point(472, 295);
            this.pchtMutualSB.Name = "pchtMutualSB";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Friends SBs";
            series2.Name = "Series1";
            series2.XValueMember = "FriendSeries.SBName";
            series2.YValueMembers = "FriendSeries.Count";
            this.pchtMutualSB.Series.Add(series2);
            this.pchtMutualSB.Size = new System.Drawing.Size(415, 285);
            this.pchtMutualSB.TabIndex = 2;
            this.pchtMutualSB.Text = "chart1";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Mutuals";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.pchtMutualSB.Titles.Add(title2);
            // 
            // pchtFollowerSB
            // 
            chartArea3.Name = "ChartArea1";
            this.pchtFollowerSB.ChartAreas.Add(chartArea3);
            legend3.Name = "Friends SBs";
            this.pchtFollowerSB.Legends.Add(legend3);
            this.pchtFollowerSB.Location = new System.Drawing.Point(472, 586);
            this.pchtFollowerSB.Name = "pchtFollowerSB";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Friends SBs";
            series3.Name = "Series1";
            series3.XValueMember = "FriendSeries.SBName";
            series3.YValueMembers = "FriendSeries.Count";
            this.pchtFollowerSB.Series.Add(series3);
            this.pchtFollowerSB.Size = new System.Drawing.Size(415, 285);
            this.pchtFollowerSB.TabIndex = 3;
            this.pchtFollowerSB.Text = "chart1";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Followers";
            title3.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270;
            this.pchtFollowerSB.Titles.Add(title3);
            // 
            // dataGridViewRWs
            // 
            this.dataGridViewRWs.AllowUserToAddRows = false;
            this.dataGridViewRWs.AllowUserToDeleteRows = false;
            this.dataGridViewRWs.AllowUserToOrderColumns = true;
            this.dataGridViewRWs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(213)))), ((int)(((byte)(180)))));
            this.dataGridViewRWs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRWs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRWs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcNickname,
            this.dgcRelation,
            this.dgcSBName,
            this.dgcFriendCode});
            this.dataGridViewRWs.Location = new System.Drawing.Point(19, 3);
            this.dataGridViewRWs.Name = "dataGridViewRWs";
            this.dataGridViewRWs.ReadOnly = true;
            this.dataGridViewRWs.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(210)))), ((int)(((byte)(228)))));
            this.dataGridViewRWs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRWs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRWs.ShowEditingIcon = false;
            this.dataGridViewRWs.Size = new System.Drawing.Size(447, 868);
            this.dataGridViewRWs.TabIndex = 0;
            // 
            // dgcNickname
            // 
            this.dgcNickname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcNickname.HeaderText = "Name";
            this.dgcNickname.MinimumWidth = 50;
            this.dgcNickname.Name = "dgcNickname";
            this.dgcNickname.ReadOnly = true;
            this.dgcNickname.Width = 60;
            // 
            // dgcRelation
            // 
            this.dgcRelation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcRelation.HeaderText = "Relation";
            this.dgcRelation.Name = "dgcRelation";
            this.dgcRelation.ReadOnly = true;
            this.dgcRelation.Width = 71;
            // 
            // dgcSBName
            // 
            this.dgcSBName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcSBName.HeaderText = "SB Name";
            this.dgcSBName.MinimumWidth = 60;
            this.dgcSBName.Name = "dgcSBName";
            this.dgcSBName.ReadOnly = true;
            this.dgcSBName.Width = 77;
            // 
            // dgcFriendCode
            // 
            this.dgcFriendCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcFriendCode.HeaderText = "Friend Code";
            this.dgcFriendCode.Name = "dgcFriendCode";
            this.dgcFriendCode.ReadOnly = true;
            this.dgcFriendCode.Width = 89;
            // 
            // FFRKViewRWs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pchtFollowerSB);
            this.Controls.Add(this.pchtMutualSB);
            this.Controls.Add(this.pchtFriendSB);
            this.Controls.Add(this.dataGridViewRWs);
            this.Name = "FFRKViewRWs";
            this.Size = new System.Drawing.Size(891, 878);
            this.Load += new System.EventHandler(this.FFRKViewInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pchtFriendSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pchtMutualSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pchtFollowerSB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRWs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewEx dataGridViewRWs;
        private System.Windows.Forms.DataVisualization.Charting.Chart pchtFriendSB;
        private System.Windows.Forms.DataVisualization.Charting.Chart pchtMutualSB;
        private System.Windows.Forms.DataVisualization.Charting.Chart pchtFollowerSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFriendCode;
    }
}
