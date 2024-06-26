﻿using System;

namespace certificacao_csharp_roteiro.Aula2___criar_tipos_de_referência._1___Tipos_de_Referência
{
    public class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 42;
            int copiaIdade = idade;

            Console.WriteLine("int idade = 42;");
            Console.WriteLine("int copiaIdade = idade;");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 32;

            Console.WriteLine();
            Console.WriteLine("idade = 32;");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            var cliente1 = new Cliente("José da Silva", 42);
            var cliente2 = cliente1;

            Console.WriteLine();
            Console.WriteLine(@"var cliente1 = new Cliente(""José da Silva"", 42);");
            Console.WriteLine("var cliente2 = cliente;");
            Console.WriteLine($"cliente1: {cliente1}");
            Console.WriteLine($"cliente2: {cliente2}");

            cliente1.Nome = "Maria de Souza";

            Console.WriteLine();
            Console.WriteLine(@"cliente1.Nome = ""Maria de Souza"";");
            Console.WriteLine($"cliente1: {cliente1}");
            Console.WriteLine($"cliente2: {cliente2}");
        }

        // se substituir por struct (tipo de valor) o comportamento muda
        class Cliente
        {
            public string Nome { get; set; }
            public int Idade { get; set; }

            public Cliente(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }

            public override string ToString()
            {
                return $"Nome: {Nome}, Idade: {Idade}";
            }
        }
    }
}