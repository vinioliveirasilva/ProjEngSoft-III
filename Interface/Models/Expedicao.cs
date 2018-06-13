using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface.Models
{
    public class Expedicao
    {
        /*
         * Propriedades especificas da classe 
         */

        private int ExpedicaoId { get; set; }
        private int PedidoId { get; set; }
        private string CreationId { get; set; }
        private ExpedicaoStatus ExpedicaoStatus { get; set; }


        /*
         * Containers de dados 
         */

        private List<Item> ExpedicaoItens = new List<Item>();

        /*
         * Metodos da classe
         */

        public Expedicao(List<Item> itens, int pedidoId, string creationId)
        {
            if (itens.Any())
                ExpedicaoItens = itens;
            PedidoId = pedidoId;
            CreationId = creationId;
            ExpedicaoStatus = ExpedicaoStatus.NaoExpedido;
        }

        public int GetExpedicaoId() => ExpedicaoId;
        public int GetPedidoId() => PedidoId;
        public string GetCreationId() => CreationId;
        public string GetExpedicaoStatus() => ExpedicaoStatus.ToString();
        public IEnumerable<Item> GetExpedicaoItens() => ExpedicaoItens;

        public ActionResult SetExpedicaoStatus(int status)
        {
            try
            {
                ExpedicaoStatus = (ExpedicaoStatus)status;
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel mudar status da expedição.");
        }

        public ActionResult AddExpedicaoItem(Item i)
        {
            try
            {
                //Verificar se item ja existe
                //se sim adicionar mais um na quantidade 
                //se não somente adiciona item
                ExpedicaoItens.Add(i);
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel adicionar o item a expedição.");
        }

        public ActionResult RemoveExpedicaoItem(int id)
        {
            try
            {
                var item = ExpedicaoItens.Where(x => x.GetItemId() == id).FirstOrDefault(null);

                if (item != null)
                    ExpedicaoItens.Remove(item);
                else
                    return ActionResult.CreateFailAction("Item não existe na expedição.");
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel remover o item dessa expedição.");
        }
    }
}