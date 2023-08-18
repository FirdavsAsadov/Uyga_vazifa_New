namespace N28_CT_PgAdmin;

public class PersonService
{
    private readonly EFCoreContext _context;
    public PersonService(EFCoreContext context)
    {
        _context = context;
    }
    
    
}