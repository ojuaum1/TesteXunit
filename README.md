### Projeto de Testes de Cálculos com C# e xUnit
Este projeto é uma implementação de testes unitários para funções de cálculo utilizando a linguagem C# e o framework de testes xUnit. Ele serve como um exemplo de como escrever e organizar testes unitários para validar a corretude de funções matemáticas.

### Requisitos
.NET SDK (versão 6.0 ou superior)
IDE (Visual Studio, Visual Studio Code, Rider, etc.)

### Estrutura do Projeto
### O projeto está organizado da seguinte maneira:

/Calculations
  /src
    /Calculations
      Calculations.cs
  /tests
    /Calculations.Tests
      CalculationsTests.cs

### Calculations.cs: Contém as funções de cálculo que serão testadas.
### CalculationsTests.cs: Contém os testes unitários para as funções em Calculations.cs.

### Instalação
### Clone o repositório:
### bash
### Copiar código
### git clone https://github.com/seuusuario/calculations-tests.git
Navegue até o diretório do projeto:
bash
Copiar código
cd calculations-tests
Restaure os pacotes NuGet:
bash
Copiar código
dotnet restore
Execução dos Testes
Para executar os testes, use o comando:

bash
Copiar código
dotnet test
Exemplo de Código
Funções de Cálculo (Calculations.cs)
csharp
Copiar código
namespace Calculations
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException();
            return (double)a / b;
        }
    }
}
Testes Unitários (CalculationsTests.cs)
csharp
Copiar código
using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            Assert.Equal(4, _calculator.Add(2, 2));
        }

        [Fact]
        public void Subtract_ReturnsCorrectDifference()
        {
            Assert.Equal(0, _calculator.Subtract(2, 2));
        }

        [Fact]
        public void Multiply_ReturnsCorrectProduct()
        {
            Assert.Equal(4, _calculator.Multiply(2, 2));
        }

        [Fact]
        public void Divide_ReturnsCorrectQuotient()
        {
            Assert.Equal(2, _calculator.Divide(4, 2));
        }

        [Fact]
        public void Divide_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(4, 0));
        }
    }
}
Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests com melhorias ou correções.

Licença
Este projeto está licenciado sob a MIT License.

Contato
Para mais informações, entre em contato:

Nome: Seu Nome
Email: seu.email@dominio.com
GitHub: seuusuario
