using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace exerciciosEncapsulamento
{
    public class Pessoa
    {
        // atributos
        public string? Nome {get; set;}
        public int Idade {get; set;}
        public string? Cidade {get; set;}

        // metodos
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Cidade: {Cidade}");
        }
    }

    public class Calculadora
    {
        // atributos
        public int Numero1 {get; set;}
        public int Numero2 {get; set;}
        public int Resultado {get; private set;}
        // metodos
        public void Somar()
        {
            Resultado = Numero1 + Numero2;
            Console.WriteLine($"Resultado da soma: {Resultado}");
        }
        public void Subtrair()
        {
            Resultado = Numero1 - Numero2;
            Console.WriteLine($"Resultado da subtração: {Resultado}");
        }
        public void Multiplicar()
        {
            Resultado = Numero1 * Numero2;
            Console.WriteLine($"Resultado da multiplicação: {Resultado}");
        }
        public static double Dividir(double numero1, double numero2)
        {
           return numero1 / numero2;
        }
    }

    public class Veiculo
    {
        // atributo 
        public int Velocidade {get; set;}
        // metodos
        public void alterarVelocidade (int novaVelocidade)
        {
            if (novaVelocidade >= 0 && novaVelocidade <= 200)
            {
                Velocidade = novaVelocidade;
                Console.WriteLine($"Velocidade alterada para: {Velocidade} km/h");
            }
            else
            {
                Console.WriteLine("Velocidade inválida. A velocidade deve estar entre 0 e 200 km/h.");
            }
        }
    }

    public class Funcionario
    {
        // atributo
        public string? Nome {get; set;}
        public string? Cargo {get; set;}
        public decimal? Salario {get; private set;}

        // metodos

        public void AumentarSalario(decimal porcentagem)
        {
            if(porcentagem > 0)
            {
                decimal? aumento = Salario * porcentagem;
                Salario += aumento;
                Console.WriteLine($"Salário aumentado para: {Salario:C}");
            }
            else
            {
                Console.WriteLine("Aumento inválido. O aumento deve ser maior que zero.");
            }
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"Salário atual de {Nome}: {Salario:C}");
        }

        public void AtribuirSalario(decimal salarioInicial)
        {
            if(salarioInicial > 0)
            {
                Salario = salarioInicial;
                Console.WriteLine($"Salário inicial atribuído para {Nome}: {Salario:C}");
            }
            else
            {
                Console.WriteLine("Salário inicial inválido. O salário deve ser maior que zero.");
            }
        }
    }

    public class Livro
    {
        // atributos
        public string? Titulo {get; set;}
        public string? Autor {get; set;}
        public int NumeroPaginas {get; set;}

        // metodos
        public Livro()
        {
            Titulo = "Não informado";
            Autor = "Não informado";
            NumeroPaginas = 0;
        }
        public Livro(string titulo)
        {
            Titulo = titulo;
            Autor = "Não informado";
            NumeroPaginas = 0;
        }
        public Livro (string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = 0;
        }
        public Livro (string titulo, string autor, int numeropaginas)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeropaginas;

        }
        public void Exibir()
        {
            Console.WriteLine($"Titulo: {Titulo}, Autor: {Autor}, Numero de páginas: {NumeroPaginas}");
        }
    }
}