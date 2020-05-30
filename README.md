# Interfaces 📝

Interface é um tipo que define um conjunto de operações, funções ou métodos que uma classe (ou struct) deve implementar.

A interface estabelece um **contrato** que a classe (ou struct) deve cumprir.

```csharp
interface IShape {
  double Area();
  double Perimeter();
}
```

#### Mas pra quê Interfaces?

- Para criar sistemas de **_baixo acoplamento_** e **_flexiveis_**

Sem as interfaces, nosso sistema acaba por ter um forte acoplamento e nossas classes acabam por ter classes concretas como suas depêndencias. Tendo isso em mente, caso essa depência mude, precisaremos mudar também nas classes concretas.

Quando utilizamos interfaces, nos temos um baixo acoplamento entre as classes, tornando nosso sistema mais flexível e de fácil manutenção.

#### Inversão de controle

Padrão de desenvolvimento que consiste em retirar da classe a responsabilidade de instanciar suas depêndencias.

#### Injeção de Depêndencia

É uma forma de realizar a inversão de controle: um componente externo instancia a dependência, que é  então injetada no objeto "pai". Pode ser
implementada de várias formas:

- Construtor
- Objeto de instanciação `(builder, factory)`
- Container ou Framework

#### Interface IComparable

Define um método de comparação de tipo específico generalizado que implementa uma classe ou um tipo de valor para solicitar ou classificar suas instâncias

```csharp
interface IComparable {
  int CompareTo (object other);
}
```

Outro exemplo:

```csharp
namespace Course {
  // Classe Employee implementa a Interface IComparable
  class Employee : IComparable { 

    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string csvEmployee) {
      string[] vect = csvEmployee.Split(',');
      Name = vect[0];
      Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
    }
    
    public override string ToString() {
      return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
    }

    // Método da Interface IComparable implementado
    public int CompareTo(object obj) {
      if (!(obj is Employee)) {
        throw new ArgumentException("Comparing error: argument is not an Employee");
      }
      Employee other = obj as Employee;
      return Name.CompareTo(other.Name);
    }
  }
}
```