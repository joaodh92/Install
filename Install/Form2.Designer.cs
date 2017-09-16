namespace Install
{
    partial class Form2
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
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbArguments = new System.Windows.Forms.TextBox();
            this.cell1 = new System.Windows.Forms.Label();
            this.cell3 = new System.Windows.Forms.Label();
            this.cell2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonBrowse = new System.Windows.Forms.Button();
            this.TbTags = new System.Windows.Forms.TextBox();
            this.cell5 = new System.Windows.Forms.Label();
            this.cell6 = new System.Windows.Forms.Label();
            this.TbVersion = new System.Windows.Forms.TextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.cell7 = new System.Windows.Forms.Label();
            this.TbTags1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cell4 = new System.Windows.Forms.Label();
            this.cell8 = new System.Windows.Forms.Label();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(73, 3);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(228, 20);
            this.TbName.TabIndex = 0;
            // 
            // TbArguments
            // 
            this.TbArguments.Location = new System.Drawing.Point(73, 135);
            this.TbArguments.Name = "TbArguments";
            this.TbArguments.Size = new System.Drawing.Size(228, 20);
            this.TbArguments.TabIndex = 3;
            // 
            // cell1
            // 
            this.cell1.AutoSize = true;
            this.cell1.Location = new System.Drawing.Point(3, 0);
            this.cell1.Name = "cell1";
            this.cell1.Size = new System.Drawing.Size(35, 13);
            this.cell1.TabIndex = 5;
            this.cell1.Text = "Name";
            this.cell1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cell3
            // 
            this.cell3.AutoSize = true;
            this.cell3.Location = new System.Drawing.Point(3, 88);
            this.cell3.Name = "cell3";
            this.cell3.Size = new System.Drawing.Size(29, 13);
            this.cell3.TabIndex = 6;
            this.cell3.Text = "Path";
            // 
            // cell2
            // 
            this.cell2.AutoSize = true;
            this.cell2.Location = new System.Drawing.Point(3, 44);
            this.cell2.Name = "cell2";
            this.cell2.Size = new System.Drawing.Size(31, 13);
            this.cell2.TabIndex = 7;
            this.cell2.Text = "Type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CbType
            // 
            this.CbType.FormattingEnabled = true;
            this.CbType.Items.AddRange(new object[] {
            "Portable",
            "Executable"});
            this.CbType.Location = new System.Drawing.Point(73, 47);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(121, 21);
            this.CbType.TabIndex = 11;
            this.CbType.Text = "Portable";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(623, 17);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "Ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(623, 50);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 13;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonBrowse
            // 
            this.ButtonBrowse.Location = new System.Drawing.Point(307, 135);
            this.ButtonBrowse.Name = "ButtonBrowse";
            this.ButtonBrowse.Size = new System.Drawing.Size(75, 23);
            this.ButtonBrowse.TabIndex = 14;
            this.ButtonBrowse.Text = "Browse";
            this.ButtonBrowse.UseVisualStyleBackColor = true;
            this.ButtonBrowse.Visible = false;
            this.ButtonBrowse.Click += new System.EventHandler(this.ButtonBrowse_Click);
            // 
            // TbTags
            // 
            this.TbTags.Location = new System.Drawing.Point(73, 179);
            this.TbTags.Name = "TbTags";
            this.TbTags.Size = new System.Drawing.Size(228, 20);
            this.TbTags.TabIndex = 17;
            // 
            // cell5
            // 
            this.cell5.AutoSize = true;
            this.cell5.Location = new System.Drawing.Point(3, 176);
            this.cell5.Name = "cell5";
            this.cell5.Size = new System.Drawing.Size(31, 13);
            this.cell5.TabIndex = 19;
            this.cell5.Text = "Tags";
            // 
            // cell6
            // 
            this.cell6.AutoSize = true;
            this.cell6.Location = new System.Drawing.Point(3, 218);
            this.cell6.Name = "cell6";
            this.cell6.Size = new System.Drawing.Size(42, 13);
            this.cell6.TabIndex = 20;
            this.cell6.Text = "Version";
            // 
            // TbVersion
            // 
            this.TbVersion.Location = new System.Drawing.Point(73, 221);
            this.TbVersion.Name = "TbVersion";
            this.TbVersion.Size = new System.Drawing.Size(228, 20);
            this.TbVersion.TabIndex = 21;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(73, 265);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(228, 20);
            this.TbDescription.TabIndex = 23;
            // 
            // cell7
            // 
            this.cell7.AutoSize = true;
            this.cell7.Location = new System.Drawing.Point(3, 262);
            this.cell7.Name = "cell7";
            this.cell7.Size = new System.Drawing.Size(60, 13);
            this.cell7.TabIndex = 22;
            this.cell7.Text = "Description";
            // 
            // TbTags1
            // 
            this.TbTags1.Location = new System.Drawing.Point(73, 309);
            this.TbTags1.Name = "TbTags1";
            this.TbTags1.Size = new System.Drawing.Size(228, 20);
            this.TbTags1.TabIndex = 24;
            this.TbTags1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.TbPath, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cell4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cell7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cell6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TbTags1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cell5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TbDescription, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.TbName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CbType, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TbVersion, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TbArguments, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TbTags, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.cell2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cell3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cell1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonBrowse, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.64559F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.98003F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5624F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5624F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 354);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // cell4
            // 
            this.cell4.AutoSize = true;
            this.cell4.Location = new System.Drawing.Point(3, 132);
            this.cell4.Name = "cell4";
            this.cell4.Size = new System.Drawing.Size(57, 13);
            this.cell4.TabIndex = 26;
            this.cell4.Text = "Arguments";
            // 
            // cell8
            // 
            this.cell8.AutoSize = true;
            this.cell8.Location = new System.Drawing.Point(3, 306);
            this.cell8.Name = "cell8";
            this.cell8.Size = new System.Drawing.Size(60, 13);
            this.cell8.TabIndex = 26;
            this.cell8.Text = "Description";
            this.cell8.Visible = false;
            // 
            // TbPath
            // 
            this.TbPath.Location = new System.Drawing.Point(73, 91);
            this.TbPath.Name = "TbPath";
            this.TbPath.Size = new System.Drawing.Size(228, 20);
            this.TbPath.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 373);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "Form2";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbArguments;
        private System.Windows.Forms.Label cell1;
        private System.Windows.Forms.Label cell3;
        private System.Windows.Forms.Label cell2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox CbType;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonBrowse;
        private System.Windows.Forms.TextBox TbTags;
        private System.Windows.Forms.Label cell5;
        private System.Windows.Forms.Label cell6;
        private System.Windows.Forms.TextBox TbVersion;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.Label cell7;
        private System.Windows.Forms.TextBox TbTags1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label cell4;
        private System.Windows.Forms.Label cell8;
        private System.Windows.Forms.TextBox TbPath;
    }
}