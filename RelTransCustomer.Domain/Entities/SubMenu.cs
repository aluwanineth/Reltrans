using elTransCustomer.Domain.Commons;

namespace RelTransCustomer.Domain.Entities
{
    public class SubMenu :AuditableBaseEntity
    {
        public int MenuId { get; set; }
        public string Text { get; set; }
        public string Path { get; set; }
        public string Icon { get; set; }

        public virtual Menu Menu { get; set; }
    }
}
