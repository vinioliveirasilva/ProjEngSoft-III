using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface.Models
{
    public class Fabricacao
    {
        /*
         * Propriedades especificas da classe 
         */

        private int FabricacaoId { get; set; }
        private int PedidoId { get; set; }
        private string CreationId { get; set; }
        private FabricacaoStatus FabricacaoStatus { get; set; }

        /*
         * Containers de dados 
         */


        private List<Item> FabricacaoItens = new List<Item>();

        /*
         * Metodos da classe
         */

        public Fabricacao(int pedidoId, string creationId)
        {
            PedidoId = pedidoId;
            CreationId = creationId;
            FabricacaoStatus = FabricacaoStatus.NaoIniciado;
        }

        public int GetFabricacaoId() => FabricacaoId;
        public int GetPedidoId() => PedidoId;
        public string GetCreationId() => CreationId;
        public string GetFabricacaoStatus() => FabricacaoStatus.ToString();
        public IEnumerable<Item> GetFabricacaoItens() => FabricacaoItens;
        
        public ActionResult SetFabricacaoStatus(int status)
        {
            try
            {
                FabricacaoStatus = (FabricacaoStatus)status;
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel mudar status da fabricação.");
        }

        public ActionResult AddFabricacaoItem(Item i)
        {
            try
            {
                //Verificar se item ja existe
                //se sim adicionar mais um na quantidade 
                //se não sómente adiciona item
                FabricacaoItens.Add(i);
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel adicionar o item a fabricação.");
        }

        public ActionResult RemoveFabricacaoItem(int id)
        {
            try
            {

                var item = FabricacaoItens.Where(x => x.GetItemId() == id).FirstOrDefault(null);

                if (item != null)
                    FabricacaoItens.Remove(item);
                else
                    return ActionResult.CreateFailAction("Item não existe nessa fabricação.");
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel remover o item dessa fabricação.");
        }
    }
}