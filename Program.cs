using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Bibliography;
using extraiMarca.Classes;
using extraiMarca.Model;

namespace LerPlanilha
{
    class Program
    {
        public static void Main(string[] args)
        {
            lerPlanilhas.lerPlanilhasDescricao();
            lerPlanilhas.lerPlanilhasMarca();
            comparaPlanilhas.recebeValores();
        }
    }
}
