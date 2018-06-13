using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface.Models
{
    public class Cliente
    {
        /*
         * Propriedades especificas da classe 
         */
        private string ClienteCPF;
        private string ClienteNome;
        private string ClienteEmail;
        private string ClienteTelPrim;
        private string ClienteTelSec;
        
        /*
         * Containers de dados 
         */
        private List<Pedido> ClientePedidos = new List<Pedido>();

        /*
         * Metodos da classe
         */
        public Cliente(string cpf, string nome)
        {
            ClienteCPF = cpf;
            ClienteNome = nome;
        }

        public Cliente(string cpf, string nome, string email)
        {
            ClienteCPF = cpf;
            ClienteNome = nome;
            ClienteEmail = email;
        }

        public Cliente(string cpf, string nome, string email, string telPrim)
        {
            ClienteCPF = cpf;
            ClienteNome = nome;
            ClienteEmail = email;
            ClienteTelPrim = telPrim;
        }

        public Cliente(string cpf, string nome, string email, string telPrim, string telSec)
        {
            ClienteCPF = cpf;
            ClienteNome = nome;
            ClienteEmail = email;
            ClienteTelPrim = telPrim;
            ClienteTelSec = telSec;
        }

        public ActionResult AddPedido(List<Item> items = null)
        {
            try
            {
                ClientePedidos.Add(new Pedido(items));
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }

            return ActionResult.CreateSucessAction("pedido adicionado com sucesso");
        }

        public ActionResult RemovePedido(int id)
        {
            try
            {
                var pedido = ClientePedidos.Where(x => x.GetId() == id).FirstOrDefault();

                if (pedido != null)
                    ClientePedidos.Remove(pedido);
                else
                    return ActionResult.CreateFailAction("pedido não existe");
            }
            catch(Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }
            return ActionResult.CreateSucessAction("pedido removido com sucesso");
        }

        public string GetClienteCPF() => ClienteCPF;
 
        public ActionResult SetClienteCPF(string cpf)
        {
            try
            {
                //Verificar entrada de dados
                //Remover tudo que não for numero
                //Verificar se cpf é valido
                ClienteCPF = cpf;
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }
            return ActionResult.CreateSucessAction("Cpf alterado com sucesso");
        }

        public string GetClienteNome() => ClienteNome;

        public ActionResult SetClienteNome(string nome)
        {
            try
            {
                //Verificar entrada de dados
                ClienteNome = nome;
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }
            return ActionResult.CreateSucessAction("Nome alterado com sucesso");
        }

        public string GetClienteEmail() => ClienteEmail;

        public ActionResult SetClienteEmail(string email)
        {
            try
            {
                //Verificar entrada de dados
                //verificar se email é valido

                ClienteEmail = email;
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }
            return ActionResult.CreateSucessAction("Email alterado com sucesso");
        }

        public string GetClienteTelPrim() => ClienteTelPrim;

        public ActionResult SetClienteTelPrim(string tel)
        {
            try
            {
                //Verificar entrada de dados
                //verificar se sao numeros
                //Verificar se é um numero valido

                ClienteTelPrim = tel;
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }
            return ActionResult.CreateSucessAction("Telefone primario alterado com sucesso");
        }

        public string GetClienteTelSec() => ClienteTelSec;

        public ActionResult SetClienteTelSec(string tel)
        {
            try
            {
                //Verificar entrada de dados
                //verificar se sao numeros
                //Verificar se é um numero valido
                ClienteTelSec = tel;
            }
            catch (Exception ex)
            {
                return ActionResult.CreateFailAction(ex.InnerException.ToString());
            }
            return ActionResult.CreateSucessAction("Telefone secundario alterado com sucesso");
        }
    }
}