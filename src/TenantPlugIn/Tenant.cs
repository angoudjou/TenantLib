namespace TenantPlugIn;

public class Tenant
{
    public string ID { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = string.Empty;
    public string LName { get; set; } = string.Empty;
    public string FName { get; set; } = string.Empty;
    public DateOnly DateCreat { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public DateTime DOB { get; set; } =default!;

    public Tenant()
    {
            
    }
    public Tenant(string name)
    {
        Name = name;
    }
}
