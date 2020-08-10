using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Catalogo.Domain.Tests
{
    public class ProdutoTests
    {
        [Fact]
        public void Produto_Validar_ValidacoesDevemRetornarExceptions()
        {
            //Arrange & Act & Assert
            var ex = Assert.Throws<DomainException>(() =>
               new Produto( string.Empty, "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(10, 10, 10))
            );

            Assert.Equal("O campo Nome do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
              new Produto("Nome", string.Empty, false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(10, 10, 10))
            );

            Assert.Equal("O campo Descrição do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
             new Produto("Nome", "Descrição", false, 0, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(10, 10, 10))
            );

            Assert.Equal("O campo Valor do produto não pode ser menor ou igual a 0", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
              new Produto("Nome", "Descrição", false, 100, Guid.Empty, DateTime.Now, "Imagem", new Dimensoes(10, 10, 10))
            );

            Assert.Equal("O campo CategoriaId do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
              new Produto("Nome", "Descrição", false, 100, Guid.NewGuid(), DateTime.Now, string.Empty, new Dimensoes(10, 10, 10))
            );

            Assert.Equal("O campo Imagem do produto não pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
              new Produto("Nome", "Descrição", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(0, 10, 10))
            );

            Assert.Equal("O campo altura tem que ser menor ou igual a 0", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
              new Produto("Nome", "Descrição", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(10, 0, 10))
            );

            Assert.Equal("O campo largura tem que ser menor ou igual a 0", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
              new Produto("Nome", "Descrição", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensoes(10, 10, 0))
            );

            Assert.Equal("O campo profundidade tem que ser menor ou igual a 0", ex.Message);
        }
    }
}
