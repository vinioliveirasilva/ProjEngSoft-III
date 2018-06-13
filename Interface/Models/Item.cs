using System;

namespace Interface.Models
{
    public class Item
    {
        /*
        * Propriedades especificas da classe 
        */
        private int ItemId { get; set; }
        private string ItemNome { get; set; }
        private int ItemQuantidade { get; set; }
        private decimal ItemPreco { get; set; }
        private string ItemDescricao { get; set; }

        /*
         * Metodos da classe
         */
        public Item(string nome, int quantidade, decimal preco, string descricao)
        {
            ItemNome = nome;
            ItemQuantidade = quantidade > 0 ? quantidade: int.MaxValue;
            ItemPreco = preco > 0 ? preco: int.MaxValue;
            ItemDescricao = descricao;
        }

        public int GetItemId() => ItemId;
        public string GetItemNome() => ItemNome;
        public int GetItemQuatidade() => ItemQuantidade;
        public decimal GetItemPreco() => ItemPreco;
        public string GetItemDescricaoe() => ItemDescricao;

        public ActionResult SetItemNome(string nome)
        {
            try
            {
                if (nome != string.Empty)
                    ItemNome = nome;
                else
                    return ActionResult.CreateFailAction("nome do item não pode ser vazio.");
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel mudar o nome desse item.");
        }

        public ActionResult SetItemQuatidade(int quantidade)
        {
            try
            {
                if (quantidade > 0)
                    ItemQuantidade = quantidade;
                else
                    return ActionResult.CreateFailAction("quantidade do item deve ser maior que zero.");
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel mudar a quantidade desse item.");
        }

        public ActionResult SetItemPreco(decimal preco)
        {
            try
            {
                if (preco > 0)
                    ItemPreco = preco;
                else
                    return ActionResult.CreateFailAction("preço do item deve ser maior que zero.");
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel mudar o preço desse item.");
        }

        public ActionResult SetItemDescricao(string descricao)
        {
            try
            {
                ItemDescricao = descricao;
             }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("Não foi possivel mudar a descrição desse item.");
        }

    }
}