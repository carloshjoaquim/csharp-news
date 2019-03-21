Novos recursos adicionados no C# 7.3
==============

Exemplo de utilização dos recursos adicionados ao [C# 7.3 ](https://github.com/carloshjoaquim/csharp-news) em um Console Application simples.

### Instalação

1. Faça o clone deste projeto com `git clone https://github.com/carloshjoaquim/csharp-news.git`
2. Entre na pasta do projeto cshap 7.3 com `cd csharp-news/csharp\7.3`
3. Rode a aplicação com o Visual Studio (2017+)
4. Instale o pacote para uso de Tuplas - Install-Package "System.ValueTuple"


## Recursos Aplicados

### 1. Reatribuir variáveis locais ref

    Agora, as variáveis locais ref podem ser reatribuídas para se referir a 
    diferentes instâncias depois de serem inicializadas:
```csharp
        var myStruct = new MyStruct();
        var myAnotherStruct = new MyStruct();

        ref MyStruct refLocal = ref myStruct;
        refLocal = ref myAnotherStruct;
```    

### 2. Matrizes stackalloc são compatíveis com inicializadores

    Você consegue especificar os valores dos elementos em uma matriz ao inicializá-la

```csharp  
         private unsafe void Foo()
        {
            // stackalloc arrays support initializers
            int* intArray = stackalloc int[3] { 1, 2, 3 };            
        }
```


