using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
            .UseKestrel()
                .Configure(app => {
                    app.Run(context => context.Response.WriteAsync("Seja Bem vindo!!"));
                })
                .Build();
            host.Run();
        }
    }
}