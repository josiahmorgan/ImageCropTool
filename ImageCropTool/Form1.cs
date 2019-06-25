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

namespace ImageCropTool
{
    public partial class Form1 : Form
    {
        private string filepath = "";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.KeyUp += dataGridView1_KeyUp;
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open jpg File";
            theDialog.Filter = "JPG files|*.jpg";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                    filepath = theDialog.FileName;
                    filepathLabel.Text = filepath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {

                if (filepath == "")
                {
                    MessageBox.Show("No File Selected");
                }
                else if (System.IO.File.Exists(filepath) == false)
                {
                    MessageBox.Show("File Doesn't Exist");
                }
                else
                {
                    Pen blackPen = new Pen(Color.Black, 2);
                    Brush brush = new SolidBrush(Color.FromArgb(125, 20, 20, 20));
                    Image OriginalImage = Image.FromFile(filepath);
                    Image NewImage = Image.FromFile(filepath);
                    Graphics originalGraphics = Graphics.FromImage(NewImage);
                    for (int colNum =1; colNum<11; colNum++)
                    {
                        if ((string)dataGridView1.Rows[0].Cells[colNum].Value != "" && dataGridView1.Rows[0].Cells[colNum].Value != null)
                        {
                            Rectangle CropRect = new Rectangle(Convert.ToInt32(dataGridView1.Rows[2].Cells[colNum].Value), Convert.ToInt32(dataGridView1.Rows[3].Cells[colNum].Value), Convert.ToInt32(dataGridView1.Rows[0].Cells[colNum].Value), Convert.ToInt32(dataGridView1.Rows[1].Cells[colNum].Value));
                            Rectangle CropRectZero = new Rectangle(0, 0, CropRect.Width, CropRect.Height);
                            Bitmap CropImage = new Bitmap(CropRect.Width, CropRect.Height);
                            if ((string)dataGridView1.Rows[5].Cells[colNum].Value != "" && dataGridView1.Rows[5].Cells[colNum].Value != null)
                            {
                                using (Graphics cropGraphics = Graphics.FromImage(CropImage))
                                {
                                    cropGraphics.DrawImage(OriginalImage, CropRectZero, CropRect, GraphicsUnit.Pixel);
                                    //System.IO.Path.GetDirectoryName(saveFileDialog1.FileName);
                                    CropImage.Save(System.IO.Path.GetDirectoryName(saveFileDialog1.FileName) + "\\" + (string)dataGridView1.Rows[5].Cells[colNum].Value + ".jpg");
                                }
                            }
                            if ((string)dataGridView1.Rows[4].Cells[colNum].Value == "" || dataGridView1.Rows[4].Cells[colNum].Value == null) //border no fill
                            {
                                originalGraphics.DrawRectangle(blackPen, CropRect);
                            }
                            else
                            {
                                originalGraphics.FillRectangle(brush, CropRect);
                            }
                        }
                    }
                    //MessageBox.Show(System.IO.Path.GetDirectoryName(saveFileDialog1.FileName));
                    NewImage.Save(saveFileDialog1.FileName);
                    NewImage.Dispose();
                    OriginalImage.Dispose();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "Width";
            dataGridView1.Rows[1].Cells[0].Value = "Height";
            dataGridView1.Rows[2].Cells[0].Value = "X";
            dataGridView1.Rows[3].Cells[0].Value = "Y";
            dataGridView1.Rows[4].Cells[0].Value = "fill";
            dataGridView1.Rows[5].Cells[0].Value = "saveName";


        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)

        {

            //if user clicked Shift+Ins or Ctrl+V (paste from clipboard)

            if ((e.KeyCode == Keys.Delete))
            {
                int firstRow = 999; //dataGridView1.SelectedCells[0].RowIndex;
                int firstCol = 9999;// dataGridView1.SelectedCells[0].ColumnIndex;
                int lastRow = -1;// dataGridView1.SelectedCells[dataGridView1.SelectedCells.Count-1].RowIndex;
                int lastCol = -1;// dataGridView1.SelectedCells[dataGridView1.SelectedCells.Count - 1].ColumnIndex;
                foreach(DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    firstRow = Math.Min(firstRow, cell.RowIndex);
                    firstCol = Math.Min(firstCol, cell.ColumnIndex);
                    lastRow = Math.Max(lastRow, cell.RowIndex);
                    lastCol = Math.Max(lastCol, cell.ColumnIndex);
                }
                for(int r = firstRow; r<= lastRow; r++)
                {
                    for (int c = firstCol; c <= lastCol; c++)
                    {
                        dataGridView1.Rows[r].Cells[c].Value = "";
                    }
                }
            }
                if ((e.Shift && e.KeyCode == Keys.Insert) || (e.Control && e.KeyCode == Keys.V))

            {

                char[] rowSplitter = { '\r', '\n' };

                char[] columnSplitter = { '\t' };

                //get the text from clipboard

                IDataObject dataInClipboard = Clipboard.GetDataObject();

                string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);

                //split it into lines

                string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

                //get the row and column of selected cell in grid

                int r = 9999;// dataGridView1.SelectedCells[0].RowIndex;

                int c = 9999;// dataGridView1.SelectedCells[0].ColumnIndex;



                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    r = Math.Min(r, cell.RowIndex);
                    c = Math.Min(c, cell.ColumnIndex);
                }

                //add rows into grid to fit clipboard lines

                if (dataGridView1.Rows.Count < (r + rowsInClipboard.Length))

                {

                    dataGridView1.Rows.Add(r + rowsInClipboard.Length - dataGridView1.Rows.Count);

                }

                // loop through the lines, split them into cells and place the values in the corresponding cell.

                for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)

                {

                    //split row into cell values

                    string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);

                    //cycle through cell values

                    for (int iCol = 0; iCol < valuesInRow.Length; iCol++)

                    {

                        //assign cell value, only if it within columns of the grid

                        if (dataGridView1.ColumnCount - 1 >= c + iCol)

                        {

                            dataGridView1.Rows[r + iRow].Cells[c + iCol].Value = valuesInRow[iCol];

                        }

                    }

                }

            }

        }
    }
}
