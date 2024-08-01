using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculos.Teste
{
    public class CalculoUnitTest
    {
        // AAA: Arrange, Act, Assert

        [Fact]
        public void TestarMetodoSomar()
        {
            // Arrange
            var x1 = 4.1;
            var x2 = 5.9;
            var valorEsperado = 10;

            // Act
            var soma = Calculo.somar(x1, x2);

            // Assert
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void TestarMetodoSubtrair()
        {
            // Arrange
            var x1 = 10;
            var x2 = 5;
            var valorEsperado = 5;

            // Act
            var diferenca = Calculo.subtrair(x1, x2);

            // Assert
            Assert.Equal(valorEsperado, diferenca);
        }

        [Fact]
        public void TestarMetodoMultiplicar()
        {
            // Arrange
            var x1 = 4;
            var x2 = 5;
            var valorEsperado = 20;

            // Act
            var produto = Calculo.multiplicar(x1, x2);

            // Assert
            Assert.Equal(valorEsperado, produto);
        }

        [Fact]
        public void TestarMetodoDividir()
        {
            // Arrange
            var x1 = 20;
            var x2 = 4;
            var valorEsperado = 5;

            // Act
            var quociente = Calculo.dividir(x1, x2);

            // Assert
            Assert.Equal(valorEsperado, quociente);
        }

        [Fact]
        public void TestarMetodoDividirPorZero()
        {
            // Arrange
            var x1 = 20;
            var x2 = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Calculo.dividir(x1, x2));
        }
    }
}
