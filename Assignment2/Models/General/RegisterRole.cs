namespace Assignment2.Models.General
{
    public class RegisterRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public RegisterRole(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }
    }
}
