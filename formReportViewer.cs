using iTextSharp.text;
using iTextSharp.text.pdf;
using Document = iTextSharp.text.Document;
using Element = iTextSharp.text.Element;
using Font = iTextSharp.text.Font;
using PageSize = iTextSharp.text.PageSize;
using PdfWriter = iTextSharp.text.pdf.PdfWriter;


namespace TPSysacad___Forms
{
    public partial class formReportViewer : Form
    {
        private DateTime _fechaInicio;
        private DateTime _fechaFin;
        private string _titulo;
        private List<object> _datos;

        public formReportViewer(string titulo, DateTime fechaInicio, DateTime fechaFin, List<object> datos)
        {
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
            _titulo = titulo;
            _datos = datos;
            InitializeComponent();
        }

        private void formReportViewer_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = _titulo;
            dgvDatos.DataSource = _datos;
        }

        private void btnExportarAPDF_Click(object sender, EventArgs e)
        {
            if (dgvDatos.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Reporte.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No es posible escribir en el disco: " + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            Font Titulo = FontFactory.GetFont("Arial", 22);
                            Paragraph titulo = new Paragraph($"{_titulo}\n\n", Titulo);
                            PdfPTable pdfTable = new PdfPTable(dgvDatos.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dgvDatos.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dgvDatos.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.AddTitle(_titulo);
                                pdfDoc.Add(titulo);
                                pdfDoc.Add(new Paragraph());
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Reporte guardado con exito", "Aviso");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay datos para guardar", "Info");
            }
        }

        private void btnExportarAExcel_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void copyAlltoClipboard()
        {
            dgvDatos.SelectAll();
            DataObject dataObj = dgvDatos.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }
    }
}
