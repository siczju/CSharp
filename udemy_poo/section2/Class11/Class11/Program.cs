/*
    O projeto C#, ele é uma solução -> Arquivo .sln (arquivo da solução) a partir dele que vc abre o projeto
    Arquivo .csproj -> arquivo de configuração do projeto, mexeremos quando precisar acrescentar uma dependencia
    Arquivo .cs -> arquivo da linguagem c#
    .obj e .bin -> arquivos compilados
 */

using System; // Referencia para o namespace chamado system -> namespace padrão do .NET -> possui funções
              // básicas de manipulação de programas

namespace Clas11{ // namespace -> agrupamento de classes relacionadas -> nosso programa pode ser parte de um namespace (organização),
                  // tem o mesmo nome do projeto mas pode ter outros nomes. Estamos declarando que o meu programa (a classe Class11)
                  // está dentro do meu namespace Class11.
                  // não é obrigatório (pode apagar se quiser) mas é boa prática.

    // todo codigo fonte que vc escrever em C#, ele tem q estar dentro de uma classe, a classe é a unidade basica da
    // programação orientada a objetos
    internal class Program // A classe tem o mesmo nome do arquivo, mas não é obrigatório
    {
        static void Main(string[] args) // membro da classe | É uma declaração padrão para identificar o ponto de entrada,
                                        // onde a execução começa
        {
            Console.WriteLine("Hello World!"); // função básica do namespace System;
        }
    }
}