using Microsoft.EntityFrameworkCore;

namespace Inventory.AuthManagement
{
    [PrimaryKey(nameof(UserId), nameof(RoleId))]
    public class UserRole
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
   
    }
}