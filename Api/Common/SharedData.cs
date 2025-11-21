namespace Api.Common
{
    public static class SharedData
    {
        public const string Admin = "admin";
        public const string Comsumer = "comsumer";

        public static IReadOnlyList<string> AllRoles 
        {
            get => new List<string>() { Admin, Comsumer };
        }
    }
}
