using NerdStore.Core.DomainObjects;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class CategoriaTests
    {
        [Fact]
        public void Categoria_Validar_ValidacoesDevemRetornarExceptions()
        {
            //Arrange & Act & Assert
            var ex = Assert.Throws<DomainException>(() =>
               new Categoria(string.Empty, 100)
            );

            Assert.Equal("O campo Nome do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
              new Categoria("Nome", 0)
            );

            Assert.Equal("O campo Codigo não pode ser 0", ex.Message);
        }
    }
}
