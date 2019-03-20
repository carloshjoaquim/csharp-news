Novos recursos adicionados no C# 7.2
==============

Exemplo de utilização dos recursos adicionados ao [C# 7.2 ](https://github.com/carloshjoaquim/csharp-news) em um Console Application simples.

### Instalação

1. Faça o clone deste projeto com `git clone https://github.com/carloshjoaquim/csharp-news.git`
2. Entre na pasta do projeto cshap 7 com `cd csharp-news/csharp\7.2`
3. Rode a aplicação com o Visual Studio (2017+)
4. Instale o pacote para uso de Tuplas - Install-Package "System.ValueTuple"


## Recursos Aplicados

### 1. Argumentos nomeados que não estejam à direita 

    Agora as chamadas de método podem usar argumentos nomeados que precedem argumentos posicionais 
    quando esses argumentos nomeados estão nas posições corretas:
```csharp
         public static void printValues(string name, string lastName, int age = 18, string code = "Default Code")
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"LastName: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Code: {code}");
            Console.WriteLine("==");
        }

        printValues(name: "Carlos", lastName: "Joaquim", 26);
        printValues(lastName: "Example", name: "Person", age: 30, code: "Code ABC");
```    

### 2. Modificador de acesso protegido privado

    Um novo modificador de acesso composto: private protected indica que um membro pode ser 
    acessado pela classe que o contém ou por classes derivadas que são declaradas no mesmo assembly. 
    Enquanto que protected internal permite o acesso por classes derivadas ou classes que estejam no mesmo assembly, 
    o private protected limita o acesso a tipos derivados declarados no mesmo assembly.

```csharp  
        public class Vehicle
    {
        public string Color { get; set; }
        public int CV { get; set; }
        public string Code { get; set; }


        private protected void ShowProperties()
        {
            Console.WriteLine($"Type: {Color}-{CV}-{Code}");
        }
    }    
```
   Chamada na classe derivada:

```csharp 
        public class VehicleTest : Vehicle
    {
        new public void ShowProperties()
        {
            Console.WriteLine("Vehicle Properties: ");
            base.ShowProperties();
        }
    }

```


