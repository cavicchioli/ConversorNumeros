using ConverteNumero;
using System.Collections.Generic;
using Xunit;

namespace TesteUnitario
{
    public class ConversorTests
    {
        Dictionary<int, string> dicionario;

        public ConversorTests()
        {
            dicionario = Program.criarDicionario();
        }

        [Fact]
        public void RetornarNumeroExtenso_Entra1_ReturnUm()
        {
            var result = Program.retornarNumeroExtenso(1, dicionario);
            Assert.Equal("um", result);
        }

        [Fact]
        public void RetornarNumeroExtenso_Entra100_ReturnCem()
        {
            var result = Program.retornarNumeroExtenso(100, dicionario);
            Assert.Equal("cem", result);
        }

        [Fact]
        public void RetornarNumeroExtenso_Entra35_ReturnTrintaECinco()
        {
            var result = Program.retornarNumeroExtenso(35, dicionario);
            Assert.Equal("trinta e cinco", result);
        }

        [Fact]
        public void RetornarNumeroExtenso_Entra305_ReturnTrezentosECinco()
        {
            var result = Program.retornarNumeroExtenso(305, dicionario);
            Assert.Equal("trezentos e cinco", result);
        }

        [Fact]
        public void RetornarNumeroExtenso_Entra829_ReturnOitocentosEVinteENove()
        {
            var result = Program.retornarNumeroExtenso(829, dicionario);
            Assert.Equal("oitocentos e vinte e nove", result);
        }

        [Fact]
        public void RetornarNumeroExtenso_Entra101_ReturnCentoEUm()
        {
            var result = Program.retornarNumeroExtenso(101, dicionario);
            Assert.Equal("cento e um", result);
        }

        [Fact]
        public void RetornarNumeroExtenso_Entra122_ReturnCentoEVinteEDois()
        {
            var result = Program.retornarNumeroExtenso(122, dicionario);
            Assert.Equal("cento e vinte e dois", result);
        }
    }
}
