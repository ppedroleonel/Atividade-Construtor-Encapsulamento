using exerciciosEncapsulamento;

// ? Exercicio 1

// pessoa 1
// Pessoa p1 = new Pessoa();

// p1.Nome = "Pedro";
// p1.Idade = 17;
// p1.Cidade = "São Paulo";

// p1.Apresentar();

// pessoa 2

// Pessoa p2 = new Pessoa();

// p2.Nome = "julia";
// p2.Idade = 18;
// p2.Cidade = "Guarulhos";

// p2.Apresentar();

// ? Exercicio 2

// Calculadora objetoCalculadora = new Calculadora();

// ! somar
// objetoCalculadora.Numero1 = 5;
// objetoCalculadora.Numero2 = 3;
// objetoCalculadora.Somar();

// ! subtrair
// objetoCalculadora.Numero1 = 5;
// objetoCalculadora.Numero2 = 3;
// objetoCalculadora.Subtrair();

// ! multiplicar
// objetoCalculadora.Numero1 = 5;
// objetoCalculadora.Numero2 = 3;
// objetoCalculadora.Multiplicar();

// ! dividir 
// Console.WriteLine($"Resultado da divisão: {Calculadora.Dividir(10, 2)}");

// ? Exercicio 3

// Veiculo velocidadeVeiculo = new Veiculo();

// int velocidadeInicial = velocidadeVeiculo.Velocidade = 10;
// Console.WriteLine($"Velocidade inicial: {velocidadeInicial}");
// velocidadeVeiculo.alterarVelocidade(200);

// ? Exercicio 4

// Funcionario contribuidor = new Funcionario();

// contribuidor.Nome = "Pedro";
// contribuidor.Cargo = "Programador";
// contribuidor.AtribuirSalario(500m);
// contribuidor.AumentarSalario(0.1m);
// contribuidor.ConsultarSalario();

// *  nao da pra atribuir o salario diretamente na program pq o atributo salario é privado e pertence a classe funcionario, entao so podemos acessar ele atraves dos metodos da classe funcionario. isso ocorre por conta do pilar da POO chamado encapsulamento, que consiste em proteger os atributos da classe para que eles nao sejam acessados diretamente de fora da classe, e sim atraves de metodos publicos que controlam o acesso a esses atributos.
// contribuidor.Salario = 1000m;

// ? Exercicio 5

// construtor inicial
// Livro construtorLivros1 = new Livro();
// construtorLivros1.Exibir();

// construtor q so pede o titulo
// Livro construtorLivros2 = new Livro("Jogos vorazes");
// construtorLivros2.Exibir();

// construtor q pede titulo e autor
// Livro construtorLivros3 = new Livro("Jogos Vorazes", "Suzanne Collins");
// construtorLivros3.Exibir();

// construtor q pede tudo
// Livro construtorLivros4 = new Livro("Jogos Vorazes", "Suzanne Collins", 280);
// construtorLivros4.Exibir();