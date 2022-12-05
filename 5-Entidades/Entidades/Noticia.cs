using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Notificacoes;

namespace Entidades.Entidades
{
    //Assinatura para que o BD crie a Tabela com o nome idicado aqui.
    //Caso o nome não seja informado a tabela será criada com o nome da classe.
    [Table ("TB_NOTICIA")]
    public class Noticia : Notifica
    {
        [Column("NTC_ID")]
        public int Id { get; set; }

        [Column("NTC_TITULO")]
        [MaxLength(255)]
        public string Titulo { get; set; }

        [Column("NTC_INFORMACAO")]
        [MaxLength(255)]
        public string Informacao { get; set; }

        [Column("NTC_ATIVO")]
        public bool Ativo { get; set; }

        [Column("NTC_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }


        //Relacionamento com Usuário.
        [ForeignKey("ApplicationUser")]
        //Define como sendo a primeira coluna da Tabela.
        [Column(Order =1)]

        public string UserId { get; set; }        
        public virtual ApplicationUser ApplicationUser { get; set; } 
        
    }
}