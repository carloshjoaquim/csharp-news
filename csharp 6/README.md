Novos recursos adicionados no C# 6.0
==============

Exemplo de utilização dos recursos adicionados ao [C# 6.0 ](https://github.com/carloshjoaquim/csharp-news) em um Console Application simples.

### Instalação

1. Faça o clone deste projeto com `git clone https://github.com/carloshjoaquim/csharp-news.git`
2. Entre na pasta do projeto cshap 6 com `cd csharp-news/csharp\ 6`
3. Rode a aplicação com o Visual Studio (2017+)


## Recursos Aplicados

### 1. Propriedades Automáticas somente Leitura

   Recurso que permite deixar mais concisa a sintaxe para geração de tipos que não podem ser alterados (read-only).
   Nas versões anteriores esse tipo de declaração era feito da seguinte forma:
```csharp
     public string FirstName { get; private set;}
 ```
   Com o C# 6.0 é possível simplificar a declaração mantendo a propriedade acessível apenas a partir do 
   seu construtor:
```csharp
     public string FirstName { get; }
```

### 2. Inicializadores de propriedade automática

   Permite que você declare o valor inicial de uma propriedade automática como parte da declaração de propriedade,
   em outras palavras permite que você defina automaticamente a inicialização da propriedade para que não seja necessário
   realizar a inicialização no momento que for utilizar.
   O código abaixo pode ser bastante simplificado:
```csharp
    // Classe Student
        public ICollection<string> Friends { get; set; }
    
    //Utilização da Classe e propriedade Friends
        Student student = new Student();
        student.Friends = new List<string>();
        student.Friends.add("José");
```
   O inicializador automático permite que não seja necessário inicializar a propriedade "Friends" antes da sua utilização:
```csharp
    // Classe Student
        public ICollection<string> Friends { get; set; } = new List<string>();
    
    //Utilização da Classe e propriedade Friends
        Student student = new Student();
        student.Friends.add("José");
```
### 3. Membros defunção aptos para expressão

  Permite criar um atributo a partir de uma expressão, o exemplo abaixo mostra como fica o código:
```csharp
   public string FullName => $"{FirstName} {LastName}";
```
  Dessa forma o atributo FullName é composto pela expressão que, nesse caso, representa a contatenação do FirstName com o LastName.
  
### 4. "using static" (Importando de forma estática)

  Esse recurso permite que seja importado os métoidos estáticos da classe desejada, utilizando a forma mais comum (apenas "using") todos os tipos do namespace são importados. Dessa forma é possível chamar os métodos estáticos sem informar explicitamente no seu código a  classe que ele pertence. Exemplos: string.IsNullOrEmpty(), Math.Pow:
```csharp
   //Como era feito
    if (string.IsNullOrEmpty(student.Class))
                student.Class = "2nd - A";
  
  //Importando a classe string através da linha : using static System.String; é possível simplificar o código
    if (IsNullOrEmpty(student.Class))
                student.Class = "2nd - A";
```

### 5. Operadores condicionais null

  Esse recurso pode ser utilizado para evitar exceções indesejadas no código (NullReferenceException), com ele é possível verificar o valor da variável de um objeto nulo sem disparar exceção, nesse caso, a variável irá receber o valor null. Exemplo:
  ```csharp
      Console.WriteLine("First Name: {0}" , student?.FirstName);
      Console.WriteLine("Last Name: {0}", student?.LastName);
  ```
  Dessa forma, caso o objeto student seja null o código não irá gerar NullReferenceException e o valor null será retornado na tela.

### 6. Interpolação de String

   Permite compor a cadeia de caracteres através de expressões, anteriormente era utilizado o string.Format ou então o "+".
```csharp
   Console.WriteLine($"Average of Grades: {average:F2} - Squared Average: {squared_average:F2}");
``` 
   Dessa forma os valores average e squared_average são adicionados na string e formatados com 2 caracteres após a vírgula, por exemplo.

### 7. Filtros de exceção

   Permite aplicar um filtro na exceção para definir se o cath deve ser aplicado ou então melhor detalhado.
 ```csharp
       try
         {
           var grade = student.Friends.ElementAt(10000);
           Console.WriteLine(grade);
          }
        catch(ArgumentOutOfRangeException ex) when (ex.StackTrace.Contains("OutOfRange"))
          {
            Console.WriteLine("Filtered Exception- Invalid Index for grades list");
          }
 ```
   Dessa forma sempre que houver uma exceção do tipo filtrado contendo a mensagem "OutOfRange" no StackTrace, o cath será disparado com a mensagem "Filtered Exception  - Invalid Index for Grades list")
   
### 8. Expressões (nameof)

  Recurso que permite a utilização do nome de uma variável, propriedade ou campo de um objeto. É muito utilizado para fornecer o item que causou a exceção como no exemplo:
```csharp
if (IsNullOrWhiteSpace(lastName))
                Console.WriteLine("Parameter cannot be blank: {0}", nameof(lastName));

```
### 9. Inicializadores de indíce

   Permite inicializar uma coleção do tipo Dictionary<Tkey, Tvalue>. No exemplo, foi utilizado para inicializar o dicionário de notas do aluno.
```csharp
public Dictionary<string, double> MGrades = new Dictionary<string, double>
        {
            ["English"] = 6.5,
            ["Math"] = 9.9,
            ["Geography"] = 8.5,
            ["History"] = 8,
        };
```

