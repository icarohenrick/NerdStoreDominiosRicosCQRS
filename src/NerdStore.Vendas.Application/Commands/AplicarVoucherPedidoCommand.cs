using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Commands
{
    public class AplicarVoucherPedidoCommand : Command
    {
        public AplicarVoucherPedidoCommand(Guid clienteid, string codigoVoucher)
        {
            ClienteId = clienteid;
            CodigoVoucher = codigoVoucher;
        }

        public Guid ClienteId { get; private set; }
        public string CodigoVoucher { get; private set; }

        public override bool EhValido()
        {
            ValidationResult = new AplicarVoucherPedidoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
