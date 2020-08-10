using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Commands
{
    public class AtualizarItemPedidoCommand : Command
    {
        public AtualizarItemPedidoCommand(Guid clienteid, Guid produtoId, int quantidade)
        {
            ClienteId = clienteid;
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }

        public Guid ClienteId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public int Quantidade { get; private set; }

        public override bool EhValido()
        {
            ValidationResult = new AtualizarItemPedidoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
