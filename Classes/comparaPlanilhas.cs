namespace extraiMarca.Classes
{
    internal class comparaPlanilhas
    {
        public static void recebeValores()
        {
            var listaDescricao = lerPlanilhas.lerPlanilhasDescricao();
            var listaMarca = lerPlanilhas.lerPlanilhasMarca();

            foreach (var marca in listaMarca)
            {
                bool marcaEncontrada = false;


                foreach (var descricao in listaDescricao)
                {
                    if (descricao.Descricao.Contains(marca.Marca))
                    {
                        Console.WriteLine($" {descricao.Descricao} ||| {marca.Marca}");
                    }
                }

                if (!marcaEncontrada)
                {
                    Console.WriteLine($"{marca.Marca}");
                }
            }
        }
    }
}

