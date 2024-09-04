namespace Inventory.AuthManagement
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Name { get; set; } // E.g., Create, Read, Update, Delete
        public string Description { get; set; }
    }

}
