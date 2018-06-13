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
        public int GetItemId() => ItemId;
        public string GetItemNome() => ItemNome;
        public int GetItemQuatidade() => ItemQuantidade;
        public decimal GetItemPreco() => ItemPreco;
        public string GetItemDescricaoe() => ItemDescricao;

    }
}