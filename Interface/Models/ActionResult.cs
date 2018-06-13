namespace Interface.Models
{
    public class ActionResult
    {
        public bool Sucesso { get; set; }
        public string Descricao { get; set; }

        static public ActionResult CreateFailAction(string descricao)
        {
            return new ActionResult { Sucesso = false, Descricao = descricao };
        }

        static public ActionResult CreateSucessAction(string descricao)
        {
            return new ActionResult { Sucesso = true, Descricao = descricao };
        }
    }
}