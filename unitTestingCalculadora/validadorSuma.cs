using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace unitTestingCalculadora
{
    public class ValidadorSuma
    {
        [Fact]
        public void validarSuma() {
            //Arrange
            var op = new Calculadora.Calculadora.Operaciones();
            int a = 2, b = 4;
            //Act
            double suma = op.suma(a, b);
            double resta = op.resta(a, b);
            double multiplicacion = op.multiplicacion(a, b);
            double division = op.division(a, b);

            //Assert
            Assert.Equal(6, suma);
            Assert.Equal(-2, resta);
            Assert.Equal(8, multiplicacion);
            Assert.Equal(0.5, division);

        }
    }
}
