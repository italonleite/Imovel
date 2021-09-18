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
            var immobile = new Immobile(ImmobileType.COMMERCIAL);

            Assert.True(immobile.ImmobileType == ImmobileType.COMMERCIAL);
        }
        [Fact]
        public void Imovel_Tipo_NaoDeveSerTipoIndefinido()
        {
            var exception =Assert.Throws<Exception>(() => new Immobile(ImmobileType.UNDEFINED));

            Assert.Equal("Deve ser definido um tipo de imóvel", exception.Message);
        }

        [Fact]
        public void Imovel_Tipo_DiferenteDoEnumDeverSerIndefinido()
        {
            
            var isDefined = Enum.IsDefined(typeof(ImmobileType), 3);

            Assert.False(isDefined);
        }
    }
}
