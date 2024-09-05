namespace Inventory.AuthManagement
{
    public class Permission
    {
        public int Id { get; set; }
        public required string Name { get; set; } // E.g., Create, Read, Update, Delete
        public required string Description { get; set; }
        public int RoleId { get; internal set; }
    }

}
