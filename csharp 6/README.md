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

