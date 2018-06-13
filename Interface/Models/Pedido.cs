using System;
using System.Collections.Generic;
using System.Linq;

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
        private double PedidoTotalPreco { get; set; }

        /*
         * Containers de dados 
         */

        private List<Item> PedidoItens = new List<Item>();
        private List<Fabricacao> PedidoFabricacao = new List<Fabricacao>();
        private List<Expedicao> PedidoExpedicao = new List<Expedicao>();

        /*
         * Metodos da classe
         */


        public Pedido(List<Item> items, string creationId)
        {
            CreationId = creationId;

            if (items != null)
                PedidoItens = items;
        }

        public int GetPedidoId() => PedidoId;
        
        public string GetCreationId() => CreationId;

        public string GetPedidoStatus() => PedidoStatus.ToString();

        public decimal GetPedidoTotalPreco() => PedidoItens.Sum(x => x.GetItemPreco() * x.GetItemQuatidade());

        public IEnumerable<Item> GetPedidoItem() => PedidoItens;

        public IEnumerable<Fabricacao> GetPedidoFabricacao() => PedidoFabricacao;

        public IEnumerable<Expedicao> GetPedidoExpedicao() => PedidoExpedicao;

        public ActionResult SetPedidoStatus(int status)
        {
            try
            {
                PedidoStatus = (PedidoStatus)status;
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel mudar status do pedido.");
        }

        public ActionResult AddPedidoItem(Item i)
        {
            try
            {
                //Verificar se item ja existe
                //se sim adicionar mais um na quantidade 
                //se não sómente adiciona item
                PedidoItens.Add(i);
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel adicionar o item ao pedido.");
        }

        public ActionResult RemovePedidoItem(int id)
        {
            try
            {

                var item = PedidoItens.Where(x => x.GetItemId() == id).FirstOrDefault(null);

                if (item != null)
                    PedidoItens.Remove(item);
                else
                    return ActionResult.CreateFailAction("Item não existe nesse pedido.");
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel remover o item ao pedido.");
        }

        public ActionResult AddPedidoFabricacao(Fabricacao f)
        {
            try
            {
                PedidoFabricacao.Add(f);
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel adicionar a fabricação ao pedido.");
        }

        public ActionResult RemovePedidoFabricacao(int id)
        {
            try
            {

                var fabricacao = PedidoFabricacao.Where(f => f.GetFabricacaoId() == id).FirstOrDefault(null);

                if (fabricacao != null)
                    PedidoFabricacao.Remove(fabricacao);
                else
                    return ActionResult.CreateFailAction("Fabricação não existe nesse pedido.");
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel remover a fabricação do pedido.");
        }


    }
}