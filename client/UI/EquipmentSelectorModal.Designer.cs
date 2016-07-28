namespace FFRKInspector.UI
{
    partial class EquipmentSelectorModal
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.dataGridViewEquipment = new System.Windows.Forms.DataGridView();
            this.ItemColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AtkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MagColunm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EvaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxRealmSynergy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(682, 476);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // dataGridViewEquipment
            // 
            this.dataGridViewEquipment.AllowUserToAddRows = false;
            this.dataGridViewEquipment.AllowUserToDeleteRows = false;
            this.dataGridViewEquipment.AllowUserToOrderColumns = true;
            this.dataGridViewEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemColumn,
            this.AtkColumn,
            this.MagColunm,
            this.MndColumn,
            this.DefColumn,
            this.ResColumn,
            this.AccColumn,
            this.EvaColumn,
            this.SpdColumn});
            this.dataGridViewEquipment.Location = new System.Drawing.Point(12, 39);
            this.dataGridViewEquipment.Name = "dataGridViewEquipment";
            this.dataGridViewEquipment.ReadOnly = true;
            this.dataGridViewEquipment.RowHeadersVisible = false;
            this.dataGridViewEquipment.Size = new System.Drawing.Size(745, 431);
            this.dataGridViewEquipment.TabIndex = 1;
            this.dataGridViewEquipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipment_CellContentClick);
            // 
            // ItemColumn
            // 
            this.ItemColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ItemColumn.HeaderText = "Item";
            this.ItemColumn.Name = "ItemColumn";
            this.ItemColumn.ReadOnly = true;
            this.ItemColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ItemColumn.Width = 52;
            // 
            // AtkColumn
            // 
            this.AtkColumn.HeaderText = "Atk";
            this.AtkColumn.MaxInputLength = 4;
            this.AtkColumn.Name = "AtkColumn";
            this.AtkColumn.ReadOnly = true;
            this.AtkColumn.Width = 65;
            // 
            // MagColunm
            // 
            this.MagColunm.HeaderText = "Mag";
            this.MagColunm.MaxInputLength = 4;
            this.MagColunm.Name = "MagColunm";
            this.MagColunm.ReadOnly = true;
            this.MagColunm.Width = 66;
            // 
            // MndColumn
            // 
            this.MndColumn.HeaderText = "Mnd";
            this.MndColumn.MaxInputLength = 4;
            this.MndColumn.Name = "MndColumn";
            this.MndColumn.ReadOnly = true;
            this.MndColumn.Width = 66;
            // 
            // DefColumn
            // 
            this.DefColumn.HeaderText = "Def";
            this.DefColumn.MaxInputLength = 4;
            this.DefColumn.Name = "DefColumn";
            this.DefColumn.ReadOnly = true;
            this.DefColumn.Width = 66;
            // 
            // ResColumn
            // 
            this.ResColumn.HeaderText = "Res";
            this.ResColumn.MaxInputLength = 4;
            this.ResColumn.Name = "ResColumn";
            this.ResColumn.ReadOnly = true;
            this.ResColumn.Width = 66;
            // 
            // AccColumn
            // 
            this.AccColumn.HeaderText = "Acc";
            this.AccColumn.MaxInputLength = 4;
            this.AccColumn.Name = "AccColumn";
            this.AccColumn.ReadOnly = true;
            this.AccColumn.Width = 66;
            // 
            // EvaColumn
            // 
            this.EvaColumn.HeaderText = "Eva";
            this.EvaColumn.MaxInputLength = 4;
            this.EvaColumn.Name = "EvaColumn";
            this.EvaColumn.ReadOnly = true;
            this.EvaColumn.Width = 66;
            // 
            // SpdColumn
            // 
            this.SpdColumn.HeaderText = "Spd";
            this.SpdColumn.MaxInputLength = 4;
            this.SpdColumn.Name = "SpdColumn";
            this.SpdColumn.ReadOnly = true;
            this.SpdColumn.Width = 66;
            // 
            // comboBoxRealmSynergy
            // 
            this.comboBoxRealmSynergy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRealmSynergy.FormattingEnabled = true;
            this.comboBoxRealmSynergy.Location = new System.Drawing.Point(636, 12);
            this.comboBoxRealmSynergy.Name = "comboBoxRealmSynergy";
            this.comboBoxRealmSynergy.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRealmSynergy.TabIndex = 0;
            this.comboBoxRealmSynergy.SelectedIndexChanged += new System.EventHandler(this.comboBoxRealmSynergy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Realm Synergy";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Atk";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mag";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 66;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Mnd";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Def";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 66;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Res";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 66;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Acc";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 66;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Eva";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 66;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Spd";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Red rows are items already equipped on other characters.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Blue rows are items with Synergy bonuses.";
            // 
            // EquipmentSelectorModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRealmSynergy);
            this.Controls.Add(this.dataGridViewEquipment);
            this.Controls.Add(this.buttonClose);
            this.Name = "EquipmentSelectorModal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataGridView dataGridViewEquipment;
        private System.Windows.Forms.DataGridViewButtonColumn ItemColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtkColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MagColunm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MndColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EvaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpdColumn;
        private System.Windows.Forms.ComboBox comboBoxRealmSynergy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}