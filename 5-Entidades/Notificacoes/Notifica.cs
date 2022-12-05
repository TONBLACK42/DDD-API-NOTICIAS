using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entidades.Notificacoes
{
    //Essa classe deve conter validações genericas que serão usadas por 
    //todos os objetos. Validações de string, decimal, vazio ou nulo...
    public class Notifica
    {

        
        public Notifica()
        {
            //Inicia nossa propriedade de lista para não dar erro.
            Notificacoes = new List<Notifica>();
        }

        //Nome da propriedade que deu erro.
        [NotMapped]
        public string NomePropriedade { get; set; }

        //Mensagem de erro que retornou.
        [NotMapped]
        public string Mensagem { get; set; }


        //Uma lista dela mesma. Lista de erros de validação do nosso objeto.
        [NotMapped]
        public List<Notifica> Notificacoes;


        //Método para podermos chamar de todos os lugares dentro 
        //do nosso objeto para validar as propriedades que são string.
        public bool ValidarPropriedadeString(string valor, string nomePropriedade)
        {
            
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                //Adiciona uma nova notificação a lista de notificações.
                Notificacoes.Add(new Notifica
                {
                    Mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade
                });

                //Retorno quando houve erro.
                return false;
            }

            return true;
        }
    }

}