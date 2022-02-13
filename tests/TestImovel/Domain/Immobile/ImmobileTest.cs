using Imovel.Domain.Models;
using System;
using Xunit;

namespace TestImovel
{
    public class ImmobileTest
    {
        [Fact]
        public void Imovel_Tipo_DeveRetornarTipoComercial()
        {
            var address = new Address();
            var immobile = new Immobile(ImmobileType.COMMERCIAL, address);

            Assert.True(immobile.ImmobileType == ImmobileType.COMMERCIAL);
        }
        [Fact]
        public void Imovel_Tipo_Indefinido_DeveGerarExceception()
        {
            var immobile = new Immobile(ImmobileType.UNDEFINED, new Address());

            var exception = Assert.Throws<Exception>(() => immobile.ValidateImmobile(immobile));

            Assert.Equal("Deve ser informado um tipo de imóvel", exception.Message);
        }

        [Fact]
        public void Imovel_Tipo_DiferenteDoEnumDeverSerIndefinido()
        {
            
            var isDefined = Enum.IsDefined(typeof(ImmobileType), 3);

            Assert.False(isDefined);
        }

        [Fact]
        public void Imovel_Criar_ComEnderecoNullDeveGerarException()
        {
            var immobile = new Immobile(ImmobileType.COMMERCIAL, null);            

            var exception = Assert.Throws<Exception>(() => immobile.ValidateImmobile(immobile));
                        
            Assert.Equal("Deve ser informado um endereço", exception.Message);


        }
    }
}
