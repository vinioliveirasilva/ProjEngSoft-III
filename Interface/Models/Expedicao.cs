using System.Collections.Generic;

namespace Interface.Models
{
    public class Expedicao
    {
        /*
         * Propriedades especificas da classe 
         */

        private int ExpedicaoId { get; set; }
        private int PedidoId { get; set; }
        private string CriationId { get; set; }


        /*
         * Containers de dados 
         */

        private List<Item> ExpedicaoItens = new List<Item>();

        /*
         * Metodos da classe
         */
    }
}