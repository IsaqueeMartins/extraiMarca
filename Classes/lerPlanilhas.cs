using ClosedXML.Excel;
using extraiMarca.Model;

namespace extraiMarca.Classes
{
    internal class lerPlanilhas
    {
        public static List<MarcaExtrair> lerPlanilhasDescricao()
        {
            string planilha = System.IO.Directory.GetCurrentDirectory() + "\\planilhas\\produtos_sem_marca25072024_1534.xlsx";
            if (File.Exists(planilha))
            {
                List<MarcaExtrair> listaDescricao = new List<MarcaExtrair>();
                var workbook = new XLWorkbook(planilha);
                var nonEmptyDataRows = workbook.Worksheet(1).RowsUsed();
                try
                {
                    foreach (var dataRow in nonEmptyDataRows)
                    {
                        if (dataRow.RowNumber() > 1)
                        {
                            var marca = new MarcaExtrair();
                            marca.ProdutoKey = dataRow.Cell(1).Value.ToString();
                            marca.Descricao = dataRow.Cell(2).Value.ToString().ToUpper();

                            listaDescricao.Add(marca);

                        }
                    }
                    return listaDescricao!;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: ", ex.Message);
                    return new List<MarcaExtrair>();
                }
            }
            else
            {
                Console.WriteLine($"A planilha {planilha} não foi encontrada");
                return new List<MarcaExtrair>();
            }


        }


        public static List<MarcaExistente> lerPlanilhasMarca()
        {
            string planilha = System.IO.Directory.GetCurrentDirectory() + "\\planilhas\\lista_marcas_preenchidas_25072024.xlsx";
            if (File.Exists(planilha))
            {


                List<MarcaExistente> listaMarca = new List<MarcaExistente>();
                var workbook = new XLWorkbook(planilha);
                var nonEmptyDataRows = workbook.Worksheet(1).RowsUsed();

                try
                {
                    foreach (var dataRow in nonEmptyDataRows)
                    {
                        if (dataRow.RowNumber() > 1)
                        {
                            var marcaExistente = new MarcaExistente();
                            marcaExistente.Marca = dataRow.Cell(1).Value.ToString().ToUpper();

                            listaMarca.Add(marcaExistente);
                        }
                    }
                    return listaMarca!;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: ", ex.Message);
                    return new List<MarcaExistente>();
                }
            }
            else
            {
                Console.WriteLine($"Planilha {planilha} não encontrado.");
                return new List<MarcaExistente>();
            }
        }
    }
}



