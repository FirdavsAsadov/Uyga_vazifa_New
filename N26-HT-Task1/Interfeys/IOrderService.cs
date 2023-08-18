using N26_HT_Task1.Model;

namespace N26_HT_Task1.Interfeys;

public interface IOrderService
{
    bool Order(Guid pruductId, DebitCard card1);
    bool Order(ProductFilterDataModel filterDataModel, DebitCard card2);
}