
namespace BannerRelinker5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveBinBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.TeamsLstBox = new System.Windows.Forms.ListBox();
            this.BinCmb = new System.Windows.Forms.ComboBox();
            this.TextureCmb = new System.Windows.Forms.ComboBox();
            this.BinNameLbl = new System.Windows.Forms.Label();
            this.TextureIdlbl = new System.Windows.Forms.Label();
            this.LoadBinBtn = new System.Windows.Forms.Button();
            this.LoadBinLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveBinBtn
            // 
            this.SaveBinBtn.Location = new System.Drawing.Point(386, 393);
            this.SaveBinBtn.Name = "SaveBinBtn";
            this.SaveBinBtn.Size = new System.Drawing.Size(94, 29);
            this.SaveBinBtn.TabIndex = 0;
            this.SaveBinBtn.Text = "Save";
            this.SaveBinBtn.UseVisualStyleBackColor = true;
            this.SaveBinBtn.Click += new System.EventHandler(this.SaveBinBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(530, 393);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(94, 29);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // TeamsLstBox
            // 
            this.TeamsLstBox.FormattingEnabled = true;
            this.TeamsLstBox.ItemHeight = 20;
            this.TeamsLstBox.Location = new System.Drawing.Point(11, 12);
            this.TeamsLstBox.Name = "TeamsLstBox";
            this.TeamsLstBox.Size = new System.Drawing.Size(219, 424);
            this.TeamsLstBox.TabIndex = 3;
            this.TeamsLstBox.DoubleClick += new System.EventHandler(this.ListBox1_DoubleClick);
            // 
            // BinCmb
            // 
            this.BinCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BinCmb.FormattingEnabled = true;
            this.BinCmb.Items.AddRange(new object[] {
            "unknow_11404.bin",
            "unknow_11405.bin",
            "unknow_11406.bin",
            "unknow_11407.bin",
            "unknow_11408.bin",
            "unknow_11409.bin",
            "unknow_11410.bin",
            "unknow_11411.bin",
            "unknow_11412.bin",
            "unknow_11413.bin",
            "unknow_11414.bin",
            "unknow_11415.bin"});
            this.BinCmb.Location = new System.Drawing.Point(343, 227);
            this.BinCmb.Name = "BinCmb";
            this.BinCmb.Size = new System.Drawing.Size(151, 28);
            this.BinCmb.TabIndex = 4;
            this.BinCmb.SelectedIndexChanged += new System.EventHandler(this.BinCmb_SelectionChangeCommitted);
            // 
            // TextureCmb
            // 
            this.TextureCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureCmb.FormattingEnabled = true;
            this.TextureCmb.Location = new System.Drawing.Point(519, 227);
            this.TextureCmb.Name = "TextureCmb";
            this.TextureCmb.Size = new System.Drawing.Size(151, 28);
            this.TextureCmb.TabIndex = 5;
            // 
            // BinNameLbl
            // 
            this.BinNameLbl.AutoSize = true;
            this.BinNameLbl.Location = new System.Drawing.Point(343, 196);
            this.BinNameLbl.Name = "BinNameLbl";
            this.BinNameLbl.Size = new System.Drawing.Size(71, 20);
            this.BinNameLbl.TabIndex = 6;
            this.BinNameLbl.Text = "Bin name";
            // 
            // TextureIdlbl
            // 
            this.TextureIdlbl.AutoSize = true;
            this.TextureIdlbl.Location = new System.Drawing.Point(519, 196);
            this.TextureIdlbl.Name = "TextureIdlbl";
            this.TextureIdlbl.Size = new System.Drawing.Size(154, 20);
            this.TextureIdlbl.TabIndex = 7;
            this.TextureIdlbl.Text = "Texture ID (GGS Style)";
            // 
            // LoadBinBtn
            // 
            this.LoadBinBtn.Location = new System.Drawing.Point(555, 301);
            this.LoadBinBtn.Name = "LoadBinBtn";
            this.LoadBinBtn.Size = new System.Drawing.Size(42, 29);
            this.LoadBinBtn.TabIndex = 8;
            this.LoadBinBtn.Text = "...";
            this.LoadBinBtn.UseVisualStyleBackColor = true;
            this.LoadBinBtn.Click += new System.EventHandler(this.LoadBinBtn_Click);
            // 
            // LoadBinLbl
            // 
            this.LoadBinLbl.AutoSize = true;
            this.LoadBinLbl.Location = new System.Drawing.Point(352, 305);
            this.LoadBinLbl.Name = "LoadBinLbl";
            this.LoadBinLbl.Size = new System.Drawing.Size(197, 20);
            this.LoadBinLbl.TabIndex = 9;
            this.LoadBinLbl.Text = "Load unknow_00017.bin_004";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.LoadBinLbl);
            this.Controls.Add(this.LoadBinBtn);
            this.Controls.Add(this.TextureIdlbl);
            this.Controls.Add(this.BinNameLbl);
            this.Controls.Add(this.TextureCmb);
            this.Controls.Add(this.BinCmb);
            this.Controls.Add(this.TeamsLstBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBinBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PES5/WE9/LE Banner Relinker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBinBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.ListBox TeamsLstBox;
        private System.Windows.Forms.ComboBox BinCmb;
        private System.Windows.Forms.ComboBox TextureCmb;
        private System.Windows.Forms.Label BinNameLbl;
        private System.Windows.Forms.Label TextureIdlbl;
        private System.Windows.Forms.Button LoadBinBtn;
        private System.Windows.Forms.Label LoadBinLbl;
    }
}

