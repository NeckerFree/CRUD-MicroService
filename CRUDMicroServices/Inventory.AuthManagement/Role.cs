namespace Inventory.AuthManagement
{
    public class Role
    {
       
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required List<Permission> Permissions { get; set; }
    }

}
