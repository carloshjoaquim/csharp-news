Novos recursos adicionados no C# 7.1
==============

Exemplo de utilização dos recursos adicionados ao [C# 7.1 ](https://github.com/carloshjoaquim/csharp-news) em um Console Application simples.

### Instalação

1. Faça o clone deste projeto com `git clone https://github.com/carloshjoaquim/csharp-news.git`
2. Entre na pasta do projeto cshap 7 com `cd csharp-news/csharp\7.1`
3. Rode a aplicação com o Visual Studio (2017+)
4. Instale o pacote para uso de Tuplas - Install-Package "System.ValueTuple"


## Recursos Aplicados

### 1. Async Main 

    Permite utilizar await no método Main.
    Antes era necessário realizar esse processo da seguinte forma:
```csharp
        static int Main()
        {
            return DoAsyncWork().GetAwaiter().GetResult();
        }
```    
    Agora é possível adicionar o await na chamada do método mudando o Main para async Task<int> Main:
```csharp
         static async Task<int> Main()
        {
            return await DoAsyncWork();
        }
```

### 2. Expressões literais padrão

    Simplificação na forma de definir o valor padrão de expressões literais.
    Antes, era necessário escrever da seguinte forma:

```csharp  
        Func<string, bool> whereClause = default(Func<string, bool>);
```
    Agora é possível setar o valor padrão de form asimplificada:

```csharp  
        Func<string, bool> whereClause = default;
```


### 3. Nomes de elementos de tupla inferidos

    Melhoria no recurso de tuplas para inicializá-las. 
    Era necessário ao iniciar os valores da tupla, passar o nome do elemento e o valor:

```csharp  
        int count = 5;
        string label = "Colors used in the map";
        var pair = (count: count, label: label);
```
    Agora é possível passar apenas os valores, desde que tenham os mesmos nomes:

```csharp  
        int count = 5;
        string label = "Colors used in the map";
        var pair = (count, label);
```