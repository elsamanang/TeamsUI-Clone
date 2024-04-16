using Material.Icons;

namespace TeamsUI.Models
{
    public class Menu
    {
        public required string Name { get; set; }
        public required MaterialIconKind IconOutline { get; set; }
        public required MaterialIconKind Icon { get; set; }
    }
}
