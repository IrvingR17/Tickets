using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;


namespace Tickets.Utilities
{
    internal class PDFGenerator
    {
        public void GenerateReport(string[,] data, string PDFTitle)
        {
            Document doc = new Document();

            string filePath = "../../PDFs/Report_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
            string logoPath = "../../Static Files/duraplayLogo.png";

            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            float maxWidth = 100f; 
            float maxHeight = 100f;
            Image logo = Image.GetInstance(logoPath);
            float widthRatio = logo.Width / maxWidth;
            float heightRatio = logo.Height / maxHeight;
            float scaleRatio = Math.Max(widthRatio, heightRatio);
            logo.ScalePercent(100f / scaleRatio);
            
            float logoX = 50f; 
            float logoY = doc.PageSize.Height - 50f; 
            logo.SetAbsolutePosition(logoX, logoY);

            doc.Add(logo);

            doc.Add(new Paragraph(" "));

            Chunk titleChunk = new Chunk(PDFTitle);
            titleChunk.Font.Size = 16;
            titleChunk.Font.SetStyle(Font.BOLD); 

            Paragraph title = new Paragraph(titleChunk);
            title.Alignment = Element.ALIGN_CENTER;

            doc.Add(title);

            doc.Add(new Paragraph(" "));


            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;

            table.AddCell("Folio");
            table.AddCell("Número de Empleado");
            table.AddCell("Nombre");
            table.AddCell("Fecha");

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    table.AddCell(data[i, j]);
                }
            }

            doc.Add(table);

            doc.Close();
        }
    }
}
