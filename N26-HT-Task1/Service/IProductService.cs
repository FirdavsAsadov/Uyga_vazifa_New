using N26_HT_Task1.Interfeys;
using N26_HT_Task1.Model;

namespace N26_HT_Task1.Service;

public  interface IProductService
{
    public  void Add(IProduct product);
    public  ProductFilterDataModel GetFilterData();
}