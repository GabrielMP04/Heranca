﻿using System;


namespace Heranca
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public Pessoa(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        protected void ApresentarPessoa()
        {
            Console.WriteLine($"Nome: {_nome}");
            Console.WriteLine($"Idade: {_idade}");
        }
    }
}
