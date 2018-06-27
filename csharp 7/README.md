Novos recursos adicionados no C# 7.0
==============

Exemplo de utilização dos recursos adicionados ao [C# 7.0 ](https://github.com/carloshjoaquim/csharp-news) em um Console Application simples.

### Instalação

1. Faça o clone deste projeto com `git clone https://github.com/carloshjoaquim/csharp-news.git`
2. Entre na pasta do projeto cshap 6 com `cd csharp-news/csharp\ 6`
3. Rode a aplicação com o Visual Studio (2017+)
4. Instale o pacote para uso de Tuplas - Install-Package "System.ValueTuple"


## Recursos Aplicados

### 1. Variáveis out 

    Aperfeiçoamento do uso de variáveis out das versões anteriores, antes era necessário declarar a variável antes 
    da sua utilização na chamada de um método, por exemplo, agora é possível efetuar a declaração na própria chamada.
```csharp
         if (student.Passed("History", out double note))
        {
            Console.WriteLine("Passed ! The note is: {0}", note);
        }
        else
        {
            Console.WriteLine("Not Passed in History! The note is: {0}", note);
        }
```

### 2. Tuplas

    As tuplas já existiam em versões anteriores ao C# 7.0, porém, a implementação e uso eram ineficientes, por exemplo,
    não era possível nomear os elementos de uma tupla (Era apenas Item1, Item2...). A partir do C# 7.0 é possível dar nomes 
    semânticos para os campos de uma tupla.
```csharp  
        (string matter, double vgrade) = student.BestMatter();
        Console.WriteLine("Your best Matter is {0} and your grade is : {1}", matter, vgrade);
```

### 3. Descartes

    Recurso adicionado para que não seja mais necessário a inclusão de parâmetros não utilizados no uso de tuplas ou 
    métodos com variáveis out.
    Antes ao C# 7.0 a desconstrução de uma tupla era algo da forma: 
```csharp  
        // O método WorstMatter() retorna uma tupla (string, double) para informar o nome da máteria e a sua nota.
        (string worst, double note) = student.WorstMatter();
```
    Porém, caso o valor da nota não fosse importante éramos obrigados a enviá-lo conforme exemplo acima. 
    Com o uso de descartes (_) podemos ignorar os valores que não são importantes, basta adicionar o _ na posição a ser ignorada:
```csharp  
        (string worst, _) = student.WorstMatter();
```

### 4. Correspondência de Padrão

    Quando tempos objetos cuja classe deriva de uma outra classe, é comum precisar realizar checagens 
    (utilizando o operador is) assim como o casting para acesso/uso de uma estrutura específica de uma das classes.
    Para acessarmos uma propriedade da classe "pai", por exemplo, era necessário o uso de casting conforme abaixo:
```csharp  
        if (student is Master)
        {
            Console.WriteLine($"The {nameof(student3)} is Master !");
            Console.WriteLine($"The Thesis of Master degree is: {((Master)student3).ThesisName}");
        }
```
    O recurso adicionado ao C#7.0 - Pattern Matching permite que na própria checagem o tipo seja específicado.
```csharp  
         if (student3 is Master master)
        {
            Console.WriteLine($"The {nameof(student3)} is Master !");
            Console.WriteLine($"The Thesis of Master degree is: {master.ThesisName}");
        }
        if (student3 is Student std)
        {
            Console.WriteLine($"The {nameof(student3)} is Student !");
            Console.WriteLine($"Class of student is:  {std.Class}");
        }
```

### 5. Retornos de ref

    Permite retornar a referência de variáveis definidadas em outro local do código.

```csharp  
        // Criação do atributo
        private int PublishedArticles = 0;

        // Alteração através de método
        public void InsertArticle(string name)
        {
            PublishedArticles += 1;
            Articles.Add(name);
        }

        // Retorno da referência em método específico
        public ref int NumberArticles()
        {
            return ref PublishedArticles;
        }

        // Chamada do método para obter a referência
        ref int number = ref student3.NumberArticles();
```

### 6. Mais membros aptos para expressão

    Com o C#7.0 é possível utilizar expressões (expression-bodied) em construtores, finalizadores, e 
    acessadores (get e set) enquanto que antes era restrito a propriedades.

```csharp  
        // Expressão utilizada no construtor da classe Master
        public Master(string thesisName) => ThesisName = ThesisName;
```