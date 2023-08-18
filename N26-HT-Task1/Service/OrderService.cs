using N26_HT_Task1.Interfeys;
using N26_HT_Task1.Model;

namespace N26_HT_Task1.Service;

public class OrderService : IOrderService
{
    private ProductService _productService;
    private PaymentService _paymentService;

    public OrderService(ProductService productService, PaymentService paymentService)
    {
        _productService = productService;
        _paymentService = paymentService;
    }

    public bool Order(Guid pruductId, DebitCard card1)
    {
        var ordered = _productService.Order(pruductId);
        if (ordered == null)
        {
            _productService.Return(pruductId);
            return false;
        }
        _paymentService.Checkout(ordered.Price,card1);
        return true;
    }

    public bool Order(ProductFilterDataModel filterDataModel, DebitCard card2)
    {
        var orderedpaymnet = _productService.Get(filterDataModel);
        decimal totalAmount = orderedpaymnet.Sum(t => t.Price);
        bool paymentSuces = _paymentService.Checkout(totalAmount, card2);
        if (!paymentSuces)
        {
            foreach (var item in orderedpaymnet)
            {
                _productService.Return(item.Id);
            }
            return false;
        }

        foreach (var item in orderedpaymnet)
        {
            _productService.Order(item.Id);
        }
        return true;
    }
}