using N26_HT_Task1.Interfeys;
using N26_HT_Task1.Model;
using Monitor = N26_HT_Task1.Model.Monitor;

namespace N26_HT_Task1.Service;


public class ProductService : IProductService
{
    
    List<IProduct> _Inventory = new List<IProduct>();
    public void Add(IProduct product)
    {
        _Inventory.Add(product);
    }

    public  ProductFilterDataModel GetFilterData()
    {
        var producttype = _Inventory.Select(item => item.GetType().FullName).ToList();
        return new ProductFilterDataModel{ProductTypes = producttype};
    }

    public IEnumerable<IProduct> Get(ProductFilterDataModel filterDataModel)
    {
        var result = _Inventory.Where(product => filterDataModel.ProductTypes.Contains(product.GetType().FullName)).Distinct().ToList();
        foreach (var item in result)
        {
            yield return CopyProduct(item);
        }
    }

    private IProduct CopyProduct(IProduct product)
    {
        if (product is Monitor monitor)
        {
            return new Monitor(monitor);
        }
        else if (product is Laptop laptop)
        {
            return new Laptop(laptop);
        }
        else if (product is Chair chair)
        {
            return new Chair(chair);
        }

        throw new ArgumentException("Unknown product type");
    }
    public IProduct Order(Guid productId)
    {
        var prodiucts = _Inventory.FirstOrDefault(name => name.Id == productId);
        if (prodiucts == null)
        {
            throw new ArgumentException("this product not found!!");
        }
        prodiucts.IsOrdered = true;
        return CopyProducts(prodiucts);

    }
    private IProduct CopyProducts(IProduct product)
    {
        if (product is Monitor monitor)
        {
            return new Monitor(monitor);
        }
        else if (product is Laptop laptop)
        {
            return new Laptop(laptop);
        }
        else if (product is Chair chair)
        {
            return new Chair(chair);
        }

        throw new ArgumentException("Unknown product type");
    }
    

    public IProduct Return(Guid productId)
    {
        var products = _Inventory.FirstOrDefault(name => name.Id == productId);
        if (products == null)
        {
            throw new ArgumentNullException("This product Not found!!");
        }

        products.IsOrdered = false;
        return CopyProduct2(products);
    }
    private IProduct CopyProduct2(IProduct product)
    {
        if (product is Monitor monitor)
        {
            return new Monitor(monitor);
        }
        else if (product is Laptop laptop)
        {
            return new Laptop(laptop);
        }
        else if (product is Chair chair)
        {
            return new Chair(chair);
        }

        throw new ArgumentException("Unknown product type");
    }
    
}