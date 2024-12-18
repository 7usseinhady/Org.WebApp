namespace Org.WebApp.SharedKernel.Interfaces;
public interface IMultiTenant
{
    Guid? TenantId { get; }
}
