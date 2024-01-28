namespace RelTransCustomer.Application.DTOs.Menu;

public record SubMenuModel
{
    public int MenuId { get; set; }
    public string Text { get; set; }
    public string Path { get; set; }
    public string Icon { get; set; }
}
