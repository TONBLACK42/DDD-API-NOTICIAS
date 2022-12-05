using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Interfaces.InterfaceServicos;
using Entidades.Entidades;

namespace Dominio.Servicos
{
    public class ServicoNoticia : IServicoNoticia
    {
        public Task AdicionaNoticis(Noticia noticia)
        {
            throw new NotImplementedException();
        }

        public Task AtualizaNoticis(Noticia noticia)
        {
            throw new NotImplementedException();
        }

        public Task<List<Noticia>> ListarNoticiasAtivas()
        {
            throw new NotImplementedException();
        }
    }
}