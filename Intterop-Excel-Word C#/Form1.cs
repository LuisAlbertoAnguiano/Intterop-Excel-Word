using System;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace Intterop_Excel_Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = Tbx_Nombre.Text;
            string Texto = Tbx_Texto.Text;

            string path = Tbx_Directorio.Text + "\\" + Nombre + ".xlsx";
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;
            Excel.Workbook wb;           

            oApp = new Excel.Application();
            oApp.Visible = true;
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);
            oSheet.Cells[1, 1] = Texto;

            oBook.SaveAs(path);
            
        }

        private void Btn_Directorio_Click(object sender, EventArgs e)
          {
            FolderBrowserDialog Directorio = new FolderBrowserDialog();
            DialogResult = Directorio.ShowDialog();
            if(DialogResult == DialogResult.OK) 
              {
                Tbx_Directorio.Text = Directorio.SelectedPath;
              }
          }

        private void button2_Click(object sender, EventArgs e)
        {
            string Nombre = Tbx_Nombre.Text;
            string Texto = Tbx_Texto.Text;

            string path = Tbx_Directorio.Text + "\\" + Nombre;

            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application oApp = new Word.Application();
            Word.Document oDocument = oApp.Documents.Add(ref ObjMiss, ref ObjMiss, ref ObjMiss, ref ObjMiss);
            oDocument.Activate();
            oApp.Selection.TypeText(Tbx_Texto.Text);
            oApp.Visible = true;
            oDocument.SaveAs2(path);
          } 
    }
}
