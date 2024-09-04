namespace Inventory.AuthManagement
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Permission> Permissions { get; set; }
    }

}
