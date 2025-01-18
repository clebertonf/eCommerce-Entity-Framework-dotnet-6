using eCommerce.Console.Query.Utils;

namespace eCommerce.Console.Query.Models;

public class UserWithDelegateLazyLoader
{
    private readonly Action<Object, string> LazyLoader;

    public UserWithDelegateLazyLoader()
    {
        
    }

    public UserWithDelegateLazyLoader(Action<Object, string> lazyLoader)
    {
        LazyLoader = lazyLoader;
    }
    
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; }  = null!;
    public string? Sex { get; set; }
    public string? Rg { get; set; }
    public string Cpf { get; set; }  = null!;
    public string? MotherName { get; set; }
    public string? FatherName { get; set; }
    public string? RegistrationStatus { get; set; }
    public DateTimeOffset RegistrationDate { get; set; }
    public Contact? Contact { get; set; }
    
    private ICollection<DeliveryAddress>? _deliveryAddresses { get; set; }

    public ICollection<DeliveryAddress>? DeliveryAddresses
    {
        get
        {
            var deliveryAddresses = _deliveryAddresses;
            return LazyLoader.Load(this, ref deliveryAddresses);
        }
        set => _deliveryAddresses = value;
    }

    public ICollection<ProductDepartment>? ProductDepartments { get; set; }
}