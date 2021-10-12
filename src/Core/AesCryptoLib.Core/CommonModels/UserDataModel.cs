namespace AesCryptoLib.Core.CommonModels
{
    public class UserData
    {
        public int Id { get; set; }
        public string NeededData { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }

    public class Root
    {
        public UserData UserData { get; set; }
    }
}
