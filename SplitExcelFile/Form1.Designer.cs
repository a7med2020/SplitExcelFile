
namespace SplitExcelFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_AddRemainderRowsToLastFile = new System.Windows.Forms.CheckBox();
            this.lbl_RemainderRows = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_NumberOfNewFiles = new System.Windows.Forms.Label();
            this.lbl_ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NumberOfRowsPerNewFiles = new System.Windows.Forms.TextBox();
            this.lbl_FileDataRowsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BrowseFileExcel = new System.Windows.Forms.Button();
            this.txt_FileExcelPath = new System.Windows.Forms.TextBox();
            this.btn_Split = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_AddRemainderRowsToLastFile);
            this.groupBox1.Controls.Add(this.lbl_RemainderRows);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_NumberOfNewFiles);
            this.groupBox1.Controls.Add(this.lbl_);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_NumberOfRowsPerNewFiles);
            this.groupBox1.Controls.Add(this.lbl_FileDataRowsCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_BrowseFileExcel);
            this.groupBox1.Controls.Add(this.txt_FileExcelPath);
            this.groupBox1.Controls.Add(this.btn_Split);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(816, 411);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chb_AddRemainderRowsToLastFile
            // 
            this.chb_AddRemainderRowsToLastFile.AutoSize = true;
            this.chb_AddRemainderRowsToLastFile.Location = new System.Drawing.Point(12, 269);
            this.chb_AddRemainderRowsToLastFile.Name = "chb_AddRemainderRowsToLastFile";
            this.chb_AddRemainderRowsToLastFile.Size = new System.Drawing.Size(340, 29);
            this.chb_AddRemainderRowsToLastFile.TabIndex = 14;
            this.chb_AddRemainderRowsToLastFile.Text = "Add remainder rows to the last file";
            this.chb_AddRemainderRowsToLastFile.UseVisualStyleBackColor = true;
            this.chb_AddRemainderRowsToLastFile.CheckedChanged += new System.EventHandler(this.chb_AddRemainderRowsToLastFile_CheckedChanged);
            // 
            // lbl_RemainderRows
            // 
            this.lbl_RemainderRows.AutoSize = true;
            this.lbl_RemainderRows.Location = new System.Drawing.Point(545, 223);
            this.lbl_RemainderRows.Name = "lbl_RemainderRows";
            this.lbl_RemainderRows.Size = new System.Drawing.Size(23, 25);
            this.lbl_RemainderRows.TabIndex = 13;
            this.lbl_RemainderRows.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "+ File for remainder Rows:";
            // 
            // lbl_NumberOfNewFiles
            // 
            this.lbl_NumberOfNewFiles.AutoSize = true;
            this.lbl_NumberOfNewFiles.Location = new System.Drawing.Point(235, 223);
            this.lbl_NumberOfNewFiles.Name = "lbl_NumberOfNewFiles";
            this.lbl_NumberOfNewFiles.Size = new System.Drawing.Size(23, 25);
            this.lbl_NumberOfNewFiles.TabIndex = 11;
            this.lbl_NumberOfNewFiles.Text = "0";
            // 
            // lbl_
            // 
            this.lbl_.AutoSize = true;
            this.lbl_.Location = new System.Drawing.Point(11, 223);
            this.lbl_.Name = "lbl_";
            this.lbl_.Size = new System.Drawing.Size(197, 25);
            this.lbl_.TabIndex = 10;
            this.lbl_.Text = "Number of new files:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number of rows per new files:";
            // 
            // txt_NumberOfRowsPerNewFiles
            // 
            this.txt_NumberOfRowsPerNewFiles.Location = new System.Drawing.Point(298, 174);
            this.txt_NumberOfRowsPerNewFiles.Name = "txt_NumberOfRowsPerNewFiles";
            this.txt_NumberOfRowsPerNewFiles.Size = new System.Drawing.Size(153, 32);
            this.txt_NumberOfRowsPerNewFiles.TabIndex = 8;
            this.txt_NumberOfRowsPerNewFiles.Text = "0";
            this.txt_NumberOfRowsPerNewFiles.TextChanged += new System.EventHandler(this.txt_NumberOfRowsPerNewFiles_TextChanged);
            this.txt_NumberOfRowsPerNewFiles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NumberOfRowsPerNewFiles_KeyPress);
            // 
            // lbl_FileDataRowsCount
            // 
            this.lbl_FileDataRowsCount.AutoSize = true;
            this.lbl_FileDataRowsCount.Location = new System.Drawing.Point(235, 130);
            this.lbl_FileDataRowsCount.Name = "lbl_FileDataRowsCount";
            this.lbl_FileDataRowsCount.Size = new System.Drawing.Size(23, 25);
            this.lbl_FileDataRowsCount.TabIndex = 7;
            this.lbl_FileDataRowsCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "File data rows count:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Excel File:";
            // 
            // btn_BrowseFileExcel
            // 
            this.btn_BrowseFileExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BrowseFileExcel.Location = new System.Drawing.Point(721, 46);
            this.btn_BrowseFileExcel.Name = "btn_BrowseFileExcel";
            this.btn_BrowseFileExcel.Size = new System.Drawing.Size(89, 36);
            this.btn_BrowseFileExcel.TabIndex = 4;
            this.btn_BrowseFileExcel.Text = "Browse";
            this.btn_BrowseFileExcel.UseVisualStyleBackColor = true;
            this.btn_BrowseFileExcel.Click += new System.EventHandler(this.btn_BrowseFileExcel_Click);
            // 
            // txt_FileExcelPath
            // 
            this.txt_FileExcelPath.Enabled = false;
            this.txt_FileExcelPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_FileExcelPath.Location = new System.Drawing.Point(115, 46);
            this.txt_FileExcelPath.Multiline = true;
            this.txt_FileExcelPath.Name = "txt_FileExcelPath";
            this.txt_FileExcelPath.Size = new System.Drawing.Size(600, 54);
            this.txt_FileExcelPath.TabIndex = 3;
            // 
            // btn_Split
            // 
            this.btn_Split.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Split.Image = global::SplitExcelFile.Properties.Resources.xlsx__3_;
            this.btn_Split.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Split.Location = new System.Drawing.Point(235, 338);
            this.btn_Split.Name = "btn_Split";
            this.btn_Split.Size = new System.Drawing.Size(386, 51);
            this.btn_Split.TabIndex = 2;
            this.btn_Split.Text = "Split";
            this.btn_Split.UseVisualStyleBackColor = true;
            this.btn_Split.Click += new System.EventHandler(this.btn_Split_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 423);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Split Excel File";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_NumberOfNewFiles;
        private System.Windows.Forms.Label lbl_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NumberOfRowsPerNewFiles;
        private System.Windows.Forms.Label lbl_FileDataRowsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BrowseFileExcel;
        private System.Windows.Forms.TextBox txt_FileExcelPath;
        private System.Windows.Forms.Button btn_Split;
        private System.Windows.Forms.Label lbl_RemainderRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chb_AddRemainderRowsToLastFile;
    }
}

