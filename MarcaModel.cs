using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extraiMarca
{
    public class MarcaModel
    {
        [Description("Código")]
        public string ProdutoKey { get; set; }

        [Description("Descrição")]
        
        public string Descricao { get; set; }
    }
}
