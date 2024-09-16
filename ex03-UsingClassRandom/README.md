<h1> Código exemplo 03 </h1>

```csharp
using System;

namespace  Project03
{
    class Program
    {
        static void Main(string[] args) 
        {
           Random dado = new Random();
           int roll01 =  dado.Next();
           int roll02 = dado.Next(101);
           int roll03 = dado.Next(50, 101);

           Console.WriteLine($"First roll: {roll01}");
           Console.WriteLine($"Second roll: {roll02}");
           Console.WriteLine($"Third roll: {roll03}");                    
        }
    }
}
```
<h2><b><i> Analise: </i></b></h2>

- Invocamos nossa diretiva <u><b>using System.</b></u>
- Criamos namespace chamado Project03 que tem como finalidade organizar de forma logica as classes que podemos criar.
- Criamos uma class chamada Program.
- Criamos o metodo principal do programa chamada Main.

<p> Dentro do bloco principal vemos observamos algumas coisas ja conhecidas, como: 

- Declaração de variaveis de tipo integer.
- chamada da classe <u><b>Console</b></u> com seu metodo <u><b>WriteLine().</b></u>
- Interpolação de variaveis de tipo inteiro dentro de uma saida numa cadeia de caracter.

<h2> Mas o que há de diferente nesse código ?</h2>

```csharp
    Random dado = new Random();
```
- Acima observamos a criação de um objeto chamado <u><b>dado</b></u>, tal objeto é uma instância pertencente a classe <u><b>Random().</b></u>
<p> Classe <u><b>Random()</b></u> tem como finalidade gerar numeros aleatórios. Porém existem 3 usos interessantes do uso no codigo acima da classe <u><b>Random().</b></u> </p>

```csharp
    int roll01 =  dado.Next();
    int roll02 = dado.Next(101);
    int roll03 = dado.Next(50, 101);
```
- Acima voce vê em destaque as 3 situações, a 1) a criação da variavel de tipo <u><b>integer roll01</b></u> que recebe objeto <u><b>dado.Next()</b></u>que irá gerar um valor pseudoaleatório dentro da faixa de representação do tipo da variável, já que não foi definido nenhum valor a principio. 2) a criação da variavel <u><b>int roll02</b></u> de tipo integer, porém, essa variavel recebe nosso objeto <u><b>dado.next()</b></u> que gera numero aleatorio de 0 a 101. 3) criamos uma nova varivael chamada de <u><b>int roll03</b></u> que recebe o objeto criado <u><b>dado.next(50, 101)</b></u> que ira gear um numero aleatório entre <u><b>50 e 101.</b></u>

<h3><b>Por fim ...</b></h3>

```csharp
     Console.WriteLine($"First roll: {roll01}");
     Console.WriteLine($"Second roll: {roll02}");
     Console.WriteLine($"Third roll: {roll03}");  
```
- Como podemos ver no codigo aicma estamos fazendo uma chamada da classe <u><b>Console</b></u> com seu metodo <u><b>WriteLine()</b></u> que tem por finalidade imprir alguma mensagem na tela, ou seja, a saida das 3 linhas acima irá imprir cada uma uma cadeia de caracter mais o conteúdo contido nas variavels declaradas anteriormente, cada qual, recebendo seu tipo de tratamento, por exemplo, irá ser impresso em <u><b>roll01</b></u> algum valor pseudoaleatorio dentro da faixa de representação do tipo da varivael que no caso é de tipo Integer, na seguda chamada a saida sera impresso novamente com outra cadeia de caracter mais o conteudo da variavel <u><b>roll02</b></u>  porém um detalhe, um numero aleatorio entre 0 e 101, e por fim a terceira saida será impresso uma cadeia de caracteres mais o conteudo da variavel <u><b>roll03</b></u> que será um numero aleatorio entre o numero 50 e 101.

<h2><b>Conclusão: </b></h2>

- Embora seja um programa simples ele possui elementos importantes que são muito usados no desenvolvimento de sistemas. No meu ver a grande vantagem do codigo em C# é ainda a claresa do código, ou seja, vemos perfeitamente o que o programa esta fazendo sem nos perder tanto com abstrações como ocorre em outras linguagens.