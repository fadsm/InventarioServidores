using Controllers.BASE;
using System;
using System.Collections.Generic;
using Model;

namespace Controllers
{
    public class MachineController : IBaseController<Machine>
    {
        public void Adicionar(Machine entity)
        {
            throw new NotImplementedException();
        }

        public Machine BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Machine entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Machine> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Machine> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
