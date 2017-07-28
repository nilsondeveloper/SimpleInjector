using NJ.SimpleInjector.ConsoleApp.Application.Interface;
using NJ.SimpleInjector.ConsoleApp.IoC;

namespace NJ.SimpleInjector.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoaApp = Bootstrapper.Container.GetInstance<IPessoaApp>();

            var pessoas = pessoaApp.ListarPessoas();

        }
    }
}
