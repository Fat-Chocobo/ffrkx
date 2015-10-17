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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewRWs = new FFRKInspector.UI.DataGridViewEx();
            this.dgcNickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcSBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcFriendCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRWs)).BeginInit();
            this.SuspendLayout();
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
            this.dgcFriendCode,
            this.dgcUserID});
            this.dataGridViewRWs.Location = new System.Drawing.Point(19, 3);
            this.dataGridViewRWs.Name = "dataGridViewRWs";
            this.dataGridViewRWs.ReadOnly = true;
            this.dataGridViewRWs.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(210)))), ((int)(((byte)(228)))));
            this.dataGridViewRWs.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRWs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRWs.ShowEditingIcon = false;
            this.dataGridViewRWs.Size = new System.Drawing.Size(485, 625);
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
            // dgcUserID
            // 
            this.dgcUserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgcUserID.HeaderText = "User ID";
            this.dgcUserID.Name = "dgcUserID";
            this.dgcUserID.ReadOnly = true;
            this.dgcUserID.Width = 68;
            // 
            // FFRKViewRWs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewRWs);
            this.Name = "FFRKViewRWs";
            this.Size = new System.Drawing.Size(816, 631);
            this.Load += new System.EventHandler(this.FFRKViewInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRWs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewEx dataGridViewRWs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcSBName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcFriendCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcUserID;
    }
}
