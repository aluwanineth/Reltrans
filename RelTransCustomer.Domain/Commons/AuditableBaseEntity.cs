namespace elTransCustomer.Domain.Commons;

public abstract class AuditableBaseEntity
{
    public virtual int Id { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public string ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
}
