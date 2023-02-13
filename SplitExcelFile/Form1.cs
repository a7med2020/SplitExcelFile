using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitExcelFile
{

    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog;
        ExcelPackage originalExcelPackage = null;
        ExcelWorksheet originalExcelWorkSheet = null;
        public Form1()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }


        private void btn_BrowseFileExcel_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "xlsx (*.xlsx)|*.xlsx| xls (*.xls)|*.xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_FileExcelPath.Text = openFileDialog.FileName;
                    FileInfo excelFile = new FileInfo(txt_FileExcelPath.Text);
                    originalExcelPackage = new ExcelPackage(excelFile);
                    originalExcelWorkSheet = originalExcelPackage.Workbook.Worksheets.First();
                    var rowCount = originalExcelWorkSheet.Dimension.End.Row;
                    lbl_FileDataRowsCount.Text = Convert.ToString(rowCount - 1);
                    CalculateNewFilesCount();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Exception !! info : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_NumberOfRowsPerNewFiles_TextChanged(object sender, EventArgs e)
        {
            CalculateNewFilesCount();
        }



        private void chb_AddRemainderRowsToLastFile_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_AddRemainderRowsToLastFile.Checked)
            {
                if (Convert.ToInt32(lbl_RemainderRows.Text) > 0)
                {
                    lbl_NumberOfNewFiles.Text = Convert.ToString(Convert.ToInt32(lbl_NumberOfNewFiles.Text));
                    lbl_RemainderRows.Text = "0";
                }
            }
            else
            {
                CalculateNewFilesCount();
            }
        }

        void CalculateNewFilesCount()
        {
            int FileDataRowsCount = 0;
            int NumberOfRowsPerNewFiles = 0;
            if (Convert.ToInt32(lbl_FileDataRowsCount.Text) > 0 && int.TryParse(lbl_FileDataRowsCount.Text, out FileDataRowsCount))
            {
                if (!string.IsNullOrEmpty(txt_NumberOfRowsPerNewFiles.Text) && Convert.ToInt32(txt_NumberOfRowsPerNewFiles.Text) > 0)
                {
                    if (int.TryParse(txt_NumberOfRowsPerNewFiles.Text, out NumberOfRowsPerNewFiles))
                    {
                        lbl_NumberOfNewFiles.Text = Convert.ToString(FileDataRowsCount / NumberOfRowsPerNewFiles);
                        lbl_RemainderRows.Text = Convert.ToString(FileDataRowsCount % NumberOfRowsPerNewFiles);
                    }
                    else
                    {
                        MessageBox.Show("You must enter an integer number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lbl_NumberOfNewFiles.Text = "0";
                    lbl_RemainderRows.Text = "0";
                }
            }
            //else
            //{
            //    MessageBox.Show("You must choose an Excel file that have data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btn_Split_Click(object sender, EventArgs e)
        {
            try
            {
                if (getSplittedFilesStartAndEndRowNumbers().Count > 1)
                {
                    List<(int startRow, int EndRow)> splittedFileStartAndEndRowNumbers = getSplittedFilesStartAndEndRowNumbers();
                    var columnCount = originalExcelWorkSheet.Dimension.End.Column;
                    int newFilesCount = Convert.ToInt32(lbl_NumberOfNewFiles.Text);
                    int FileDataRowsCount = Convert.ToInt32(lbl_FileDataRowsCount.Text);
                    int numberOfRowsPerNewFile = Convert.ToInt32(txt_NumberOfRowsPerNewFiles.Text);

                    FileInfo originalExcelFileInfo = new FileInfo(txt_FileExcelPath.Text);
                    string originalExcelFileDirectory = originalExcelFileInfo.DirectoryName;
                    string newFilesDirectory = originalExcelFileDirectory + "\\SplittedExcelFiles " + DateTime.Now.ToString("yyyyMMddHHmmss");

                    int fileIndex = 1;
                    foreach (var file in splittedFileStartAndEndRowNumbers)
                    {

                        var stream = new MemoryStream();
                        int currentFileRowsCount = file.EndRow - file.startRow + 1;
                        int currentFileTotalRowsCount = currentFileRowsCount + 1; //Plus Header

                        using (var newExcelPackage = new ExcelPackage(stream))
                        {
                            var newWorksheet = newExcelPackage.Workbook.Worksheets.Add("Sheet1");
                            var namedStyle = newExcelPackage.Workbook.Styles.CreateNamedStyle("HyperLink");
                            namedStyle.Style.Font.UnderLine = true;
                            namedStyle.Style.Font.Color.SetColor(Color.Blue);
                            //Header
                            newWorksheet.Cells[1, 1, 1, columnCount].Value = originalExcelWorkSheet.Cells[1, 1, 1, columnCount].Value;
                            newWorksheet.Cells[1, 1, 1, columnCount].Style.Font.Bold = true;
                            //Data
                            newWorksheet.Cells[2, 1, currentFileTotalRowsCount, columnCount].Value = originalExcelWorkSheet.Cells[file.startRow, 1, file.EndRow, columnCount].Value;
                            // newWorksheet.Cells[2, 1, currentFileRowsCount, columnCount].Value = newWorksheet.Cells[2, 1, currentFileRowsCount, columnCount].Value;

                            newWorksheet.Cells[newWorksheet.Dimension.Address].AutoFitColumns();
                            newWorksheet.Cells[1, 1, currentFileTotalRowsCount, columnCount].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                            // set some core property values
                            newExcelPackage.Workbook.Properties.Subject = originalExcelFileInfo.Name + " split " + fileIndex;
                            // save the new spreadsheet
                            newExcelPackage.Save();
                            // Response.Clear();
                            stream.Position = 0;

                            System.IO.Directory.CreateDirectory(newFilesDirectory);

                            string fileName = fileIndex + " " + currentFileRowsCount + " rows.xlsx";
                            //Save the new file
                            SaveFileFromStream(stream, newFilesDirectory + "\\" + fileName);
                            fileIndex++;
                        }
                    }
                    Clear();
                    MessageBox.Show("File has been splitted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Splitted files must be more than 1 file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        List<(int startRow, int endRow)> getSplittedFilesStartAndEndRowNumbers()
        {
            int newFilesCount = chb_AddRemainderRowsToLastFile.Checked ? Convert.ToInt32(lbl_NumberOfNewFiles.Text) 
                : Convert.ToInt32(lbl_RemainderRows.Text) > 0 ? Convert.ToInt32(lbl_NumberOfNewFiles.Text) + 1 : Convert.ToInt32(lbl_NumberOfNewFiles.Text);
            int FileDataRowsCount = Convert.ToInt32(lbl_FileDataRowsCount.Text);
            int numberOfRowsPerNewFiles = Convert.ToInt32(txt_NumberOfRowsPerNewFiles.Text);

            List<(int startRow, int endRow)> StartAndEndRows = new List<(int startRow, int endRow)>();
            int startRow = 2;
            for (var file = 1; file <= newFilesCount; file++)
            {
                StartAndEndRows.Add((startRow, startRow - 1 + numberOfRowsPerNewFiles)); // startRow - 1 because we start at row 2 not 1
                startRow += numberOfRowsPerNewFiles;
            }
            // Make the last sheet final row is the last row in the original sheet, and that sautable for the two cases of remainder rows
            var last = StartAndEndRows.Last();
            StartAndEndRows[StartAndEndRows.Count - 1] = (last.startRow, FileDataRowsCount + 1);
            return StartAndEndRows;
        }

        public static List<string> GetHeaderColumns(ExcelWorksheet sheet)
        {
            List<string> columns = new List<string>();
            foreach (var firstRowCell in sheet.Cells[sheet.Dimension.Start.Row, sheet.Dimension.Start.Column, 1, sheet.Dimension.End.Column])
            {
                columns.Add(firstRowCell.Text);
            }
            return columns;
        }

        public void SaveFileFromStream(Stream stream, string destPath)
        {
            using (var fileStream = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fileStream);
            }
        }


        void Clear()
        {
            lbl_FileDataRowsCount.Text = "0";
            lbl_NumberOfNewFiles.Text = "0";
            lbl_RemainderRows.Text = "0";

            txt_NumberOfRowsPerNewFiles.Text = "0";

            originalExcelPackage = null;
            originalExcelWorkSheet = null;
        }

        private void txt_NumberOfRowsPerNewFiles_KeyPress(object sender, KeyPressEventArgs e)
        {
            //accepts numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
