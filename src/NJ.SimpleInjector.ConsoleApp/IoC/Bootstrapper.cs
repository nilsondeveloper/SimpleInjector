using NJ.SimpleInjector.ConsoleApp.Application;
using NJ.SimpleInjector.ConsoleApp.Application.Interface;
using NJ.SimpleInjector.ConsoleApp.Repository;
using NJ.SimpleInjector.ConsoleApp.Repository.Interface;
using SimpleInjector;

namespace NJ.SimpleInjector.ConsoleApp.IoC
{
    public static class Bootstrapper
    {
        public static readonly Container Container;
        
        static Bootstrapper()
        {
            //Lifestyle's:
            //Scoped => instancia por request.
            //Transient => instancia por solicitacao
            //Singleton => instancia única para a classe
            
            var container = new Container();

            container.Register<IPessoaRepositorio, PessoaRepositorio>();
            container.Register<IPessoaApp, PessoaApp>();
          //  container.Register<PessoaApp>();

            container.Verify();

            Container = container;


        }
    }

}