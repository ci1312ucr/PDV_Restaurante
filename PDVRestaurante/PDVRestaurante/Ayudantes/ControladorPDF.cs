using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDVRestaurante.Ayudantes
{
    public static class ControladorPDF
    {
        public static void CrearNuevoPDF(string nombreArchivo, StringBuilder contenido)
        {
            try
            {
                var documento = new Document();
                PdfWriter.GetInstance(documento, new FileStream(nombreArchivo, FileMode.Create));
                documento.Open();
                var parrafo = new Paragraph(contenido.ToString());
                parrafo.Alignment = Element.ALIGN_CENTER;
                documento.Add(parrafo);
                documento.Close();
            }
            catch (Exception ex)
            {
                ManejoExcepciones.LogearExcepcion(ex);
            }
        }
    }
}
