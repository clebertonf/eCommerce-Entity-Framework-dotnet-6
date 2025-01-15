using Microsoft.EntityFrameworkCore;

namespace eCommerceConsole.Office.Context;

public class EcommerceOfficeContext: DbContext
{
    public EcommerceOfficeContext(DbContextOptions<EcommerceOfficeContext> options) : base(options) { }
}