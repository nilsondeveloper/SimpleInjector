using System.Collections.Generic;
using NJ.SimpleInjector.ConsoleApp.Domain;

namespace NJ.SimpleInjector.ConsoleApp.Application.Interface
{
    public interface IPessoaApp
    {
        List<Pessoa> ListarPessoas();
    }
}