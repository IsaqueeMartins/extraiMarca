using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using ClosedXML.Excel;
using extraiMarca;

namespace LerPlanilha
{
    class Program
    {
        static void Main(String[] args)
        {
            string filePathName = System.IO.Directory.GetCurrentDirectory() + "\\planilhas\\produtos_sem_marca25072024_1534.xlsx";
            if (File.Exists(filePathName))
            {
                List<MarcaModel> lista = new List<MarcaModel>();
                var workbook = new XLWorkbook(filePathName);
                var nonEmptyDataRows = workbook.Worksheet(1).RowsUsed();

                foreach (var dataRow in nonEmptyDataRows)
                {
                    if(dataRow.RowNumber() > 1)
                    {
                        var marca = new MarcaModel();
                        marca.ProdutoKey = dataRow.Cell(1).Value.ToString();
                        marca.Descricao = dataRow.Cell(2).Value.ToString();

                        lista.Add(marca);
                    }
                }
                Console.WriteLine(JsonSerializer.Serialize(lista));
            }
            }
        }
    }