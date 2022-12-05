using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidades.Entidades;

namespace Dominio.Interfaces.InterfaceServicos
{
    public interface IServicoNoticia
    {
        Task AdicionaNoticis(Noticia noticia);

        Task AtualizaNoticis(Noticia noticia);

        Task<List<Noticia>> ListarNoticiasAtivas();
        
        
    }
}