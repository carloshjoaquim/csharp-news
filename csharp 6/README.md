Novos recursos adicionados no C# 6.0
==============

Exemplo de utilização dos recursos adicionados ao [C# 6.0 ](https://github.com/carloshjoaquim/csharp-news) em um Console Application simples.

### Instalação

1. Faça o clone deste projeto com `git clone https://github.com/carloshjoaquim/csharp-news.git`
2. Entre na pasta do projeto cshap 6 com `cd csharp-news/csharp\ 6`
3. Rode a aplicação com o Visual Studio (2017+)


## Recursos Aplicados

### 1. Propriedades Automáticas somente Leitura

    Recurso que permite deixar a sintaxe na criação de tipos que não poderão ser alterados mais concisa.
    Nas versões anteriores esse tipo de declaração era feito da seguinte forma:

    ```csharp
     public string FirstName { get; private set;}
    ```
    Com o C# 6.0 é possível simplificar a declaração mantendo a propriedade acessível apenas a partir do 
    seu construtor:

    ```csharp
     public string FirstName { get; }
    ```
...

