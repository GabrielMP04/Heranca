using System;
using static System.Net.Mime.MediaTypeNames;


namespace Heranca
{
    internal class Colaborador : Pessoa
    {
        private string _cargo;
        private double _salario;

        public Colaborador(string nome, int idade, string cargo, double salario) : base(nome, idade)
        {
            _cargo = cargo;
            _salario = salario;

            ApresentarPessoa();
            ApresentarColaborador();
        }

        private void ApresentarColaborador()
        {
            Console.WriteLine($"Cargo: {_cargo}");
            Console.WriteLine($"Salario: {_salario}");
        }

        private void MostarAlgumacoisa(){
            Console.WriteLine("Alguma coisa");
        }

    }
}
