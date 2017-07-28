using System;

namespace NJ.SimpleInjector.ConsoleApp.Domain
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pessoa()
        {
            Id = Guid.NewGuid();
        }
    }
}