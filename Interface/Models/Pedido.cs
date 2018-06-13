using System.Collections.Generic;

namespace Interface.Models
{
    class Pedido
    {
        /*
         * Propriedades especificas da classe 
         */

        private int PedidoId { get; set; }
        private string CreationId { get; set; }
        private PedidoStatus PedidoStatus { get; set; }
        private double PedidoTotalPrice { get; set; }

        /*
         * Containers de dados 
         */

        private List<Item> PedidoItens = new List<Item>();
        private List<Fabricacao> PedidoFabricacao = new List<Fabricacao>();
        private List<Expedicao> PedidoExpedicao = new List<Expedicao>();

        /*
         * Metodos da classe
         */


        public Pedido(List<Item> items)
        {
            if (items != null)
                PedidoItens = items;
        }

        public int GetId()
        {
            return PedidoId;
        }
    }
}