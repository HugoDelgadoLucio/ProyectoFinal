using QuestPDF.Infrastructure;
using QuestPDF.Helpers;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    public class PdfGenerator
    {


        public string namereturn()
        {
            WonderOfU Gappy = new WonderOfU();
            string softoandoweto = Gappy.gennamaereci();
            return softoandoweto;
        }


        // Método para generar el PDF, ahora acepta una lista de productos
        public void GenerarPdf(List<ConexionUsuario> productos)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Nombre del archivo PDF
            var fileName = namereturn() +".pdf";

            // Obtén la ruta de la carpeta del proyecto (donde está Program.cs)
            string projectDirectory = Directory.GetCurrentDirectory();
            // Define la ruta completa donde se guardará el archivo
            string pdfFilePath = Path.Combine(projectDirectory,"pdfs", fileName);

            // Define la ruta relativa a la imagen
            string imagePath = Path.Combine(projectDirectory, "img", "Taco_Mascot.png");
            // Obtener la fecha actual
            DateTime fecha = DateTime.Now;
            string flecha = fecha.ToString();

            // Crea el documento PDF
                Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    // Agrega el encabezado
                    page.Header()
                        .AlignRight().Text("Comida Mexicana Doña").FontFamily("Times New Roman").FontSize(36);

                    // Agrega el contenido
                    page.Content()
                    .PaddingVertical(1, Unit.Centimetre)
                    .Column(x =>
                    {
                        // Añadir la imagen
                        x.Item().TranslateX(-20).TranslateY(-125).Height(150).Width(150).Image(imagePath);
                        x.Item().AlignCenter().TranslateX(-40).TranslateY(-170).Text("Dominga").FontFamily("Times New Roman").FontSize(36);
                        x.Item().TranslateX(300).TranslateY(-200).Text("-De Mexico a tu plato-").FontFamily("Times New Roman");
                        x.Item().AlignRight().TranslateY(-190).Text(flecha).FontFamily("Times New Roman").FontSize(16);

                        x.Item().Shrink().Border(1).BorderColor(Colors.White).TranslateY(-180).Table(tabla =>
                        {
                            tabla.ColumnsDefinition(columna =>
                            {
                                columna.ConstantColumn(200);
                                columna.ConstantColumn(200);
                                columna.ConstantColumn(80);
                            });
                            tabla.ExtendLastCellsToTableBottom();

                            // Agrega los encabezados de la tabla
                            tabla.Cell().Text("Producto").FontFamily("Times New Roman").FontSize(18);
                            tabla.Cell().Text("Cantidad").FontFamily("Times New Roman").FontSize(18);
                            tabla.Cell().Text("Precio").FontFamily("Times New Roman").FontSize(18);

                            // Agrega los datos de los productos pasados como parámetro
                                double totalCompra = 0;
                                foreach (var producto in productos)
                                {
                                    double totalProducto = (double)(producto.Cantidad * producto.Precio);
                                    tabla.Cell().Text(producto.Descripcion).FontFamily("Times New Roman").FontSize(16);
                                    tabla.Cell().Text(producto.Cantidad.ToString()).FontFamily("Times New Roman").FontSize(16);
                                    tabla.Cell().Text(producto.Precio.ToString()).FontFamily("Times New Roman").FontSize(16);
                                    totalCompra += totalProducto;
                                }
                            double taxes = totalCompra * 0.06; // Solo los impuestos
                            double TotalConImpuestos = totalCompra + taxes; // Sumar impuestos al total
                            x.Item().AlignLeft().Text("Total mas impuestos" + TotalConImpuestos).FontFamily("Times New Roman").FontSize(16);
                        });

                    });

                    // Agrega el pie de páginaok
                    page.Footer()
                    .AlignRight()
                    .Text(x =>
                    {
                        x.Span("Pagina ").FontFamily("Times New Roman").FontSize(10);
                        x.CurrentPageNumber().FontFamily("Times New Roman").FontSize(10);
                    });
                });
            }).GeneratePdf(pdfFilePath);  // Muestra el documento en el Companion para previsualizar

        }
    }
}
