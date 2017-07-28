using System.Collections.Generic;
using NJ.SimpleInjector.ConsoleApp.Domain;

namespace NJ.SimpleInjector.ConsoleApp.Repository.Interface
{
    public interface IPessoaRepositorio
    {
        List<Pessoa> ListarPessoas();
    }
}