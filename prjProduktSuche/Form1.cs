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
using iTextSharp.text;
using iTextSharp.text.pdf;         
using iTextSharp.text.pdf.parser;


namespace prjProduktSuche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void tbEingabefeld_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuche_Click(object sender, EventArgs e)
        {
            int index = 0;
            String temp = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = temp;

            while (index < richTextBox1.Text.LastIndexOf(tbEingabefeld.Text))
            {
                richTextBox1.Find(tbEingabefeld.Text, index, richTextBox1.TextLength, RichTextBoxFinds.None);

                richTextBox1.SelectionBackColor = Color.Orange;

                index = richTextBox1.Text.IndexOf(tbEingabefeld.Text, index) + 1;
                                
           }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnDurchsuchen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string filePath;
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    filePath = openFileDialog.FileName.ToString();


                    string strText = string.Empty;

                    try
                    {

                        PdfReader reader = new PdfReader(filePath);

                        for (int page = 1; page <= reader.NumberOfPages; page++)
                        {
                            ITextExtractionStrategy its = new iTextSharp.text.pdf.parser.LocationTextExtractionStrategy();
                            String s = PdfTextExtractor.GetTextFromPage(reader, page, its);

                            s = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(s)));
                            strText = strText + s;
                            richTextBox1.Text = strText;

                        }
                        reader.Close();
    

                }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
            }

 /*           StreamWriter File = new StreamWriter("PDF_to_Text.txt");

            File.Write(richTextBox1.Text);
            File.Close();
*/
        }


    }
}



    
