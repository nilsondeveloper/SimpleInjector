using System.Collections.Generic;
using NJ.SimpleInjector.ConsoleApp.Application.Interface;
using NJ.SimpleInjector.ConsoleApp.Domain;
using NJ.SimpleInjector.ConsoleApp.Repository.Interface;

namespace NJ.SimpleInjector.ConsoleApp.Application
{
    public class PessoaApp : IPessoaApp
    {
        private readonly IPessoaRepositorio _PessoaRepositorio;

        // Injeção via construtor
        public PessoaApp(IPessoaRepositorio pessoaRepositorio)
        {
            _PessoaRepositorio = pessoaRepositorio;
        }

        public List<Pessoa> ListarPessoas()
        {
            return _PessoaRepositorio.ListarPessoas();
        }
    }
}