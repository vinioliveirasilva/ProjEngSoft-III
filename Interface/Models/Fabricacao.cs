using System.Collections.Generic;

namespace Interface.Models
{
    public class Fabricacao
    {
        /*
         * Propriedades especificas da classe 
         */

        private int ExpedicaoId { get; set; }
        private int PedidoId { get; set; }
        private string CriationId { get; set; }
        private FabricacaoStatus FabricacaoStatus { get; set; }

        /*
         * Containers de dados 
         */


        private List<Item> FabricacaoItens = new List<Item>();

        /*
         * Metodos da classe
         */
    }
}