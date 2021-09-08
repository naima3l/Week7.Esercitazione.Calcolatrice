using System;
using Week7.Esercitazione.Calcolatrice.Core;
using Xunit;

namespace Week7.Esercitazione.Calcolatrice.Test
{
    public class UnitTest1
    {
        double? risultato;
        [Fact]
        public void TestSomma()
        {
            //Arrange
            Calculator calcolatrice = new Calculator();
            double[] numbers = new double[] { 1, 2 };
            //Act
            risultato = calcolatrice.Sum(numbers);
            //Assert
            Assert.Equal(3, risultato);
        }

        [Fact]
        public void TestDiv1()
        {
            //Arrange
            Calculator calcolatrice = new Calculator();
            double[] numbers = new double[] { 4, 2 };
            //Act
            risultato = calcolatrice.Div(numbers);
            //Assert
            Assert.Equal(2, risultato);
        }

        [Fact]
        public void TestDiv2()
        {
            //Arrange
            Calculator calcolatrice = new Calculator();
            double[] numbers = new double[] { 1, 0 };
            //Act
            risultato = calcolatrice.Div(numbers);
            //Assert
            Assert.True(risultato == null);
        }

        [Fact]
        public void TestSub()
        {
            //Arrange
            Calculator calcolatrice = new Calculator();
            double[] numbers = new double[] { 1, 2 };
            //Act
            risultato = calcolatrice.Subtraction(numbers);
            //Assert
            Assert.Equal(-1, risultato);
        }

        [Fact]
        public void TestMul()
        {
            //Arrange
            Calculator calcolatrice = new Calculator();
            double[] numbers = new double[] { 1, 2 };
            //Act
            risultato = calcolatrice.Multiiplication(numbers);
            //Assert
            Assert.Equal(2, risultato);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                        //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB2()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator(); //modificate il nome della classe in base a quella che avete voi nel Core
                                                        //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3.2, 3.2);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }


    }
}
