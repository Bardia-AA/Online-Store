using Pillow.Core.Entites;

namespace Pillow.Core.Contracts
{
    public interface IOrderRepository
    {
        void Save(Order order);
        void SetOrderToken(int orderId, string token);
        void PaymentDone(string token,int tId);
    }
}
