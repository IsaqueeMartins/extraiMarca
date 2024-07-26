using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraiMarca.Model
{
    public class MarcaExtrair
    {
        [Description("Código")]
        public string ProdutoKey { get; set; }

        [Description("Descrição")]

        public string Descricao { get; set; }
    }
}
