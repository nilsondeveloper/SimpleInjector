using System;
using System.Collections.Generic;
using NJ.SimpleInjector.ConsoleApp.Domain;
using NJ.SimpleInjector.ConsoleApp.Repository.Interface;

namespace NJ.SimpleInjector.ConsoleApp.Repository
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        public List<Pessoa> ListarPessoas()
        {
            var pessoas = new List<Pessoa>()
            {
                new Pessoa(){Nome = "Nilson Júnior",DataNascimento = new DateTime(1989,03,28)},
                new Pessoa(){Nome = "Joãozinho",DataNascimento = new DateTime(1990,04,28)}
            };
            return pessoas;
        }
    }
}