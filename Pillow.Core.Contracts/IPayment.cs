using Pillow.Core.Entites;

namespace Pillow.Core.Contracts
{
    public interface IPayment
    {
        PaymentResult pay(string price);
        VerifyPayment Verify(string transactonID);
    }
}
