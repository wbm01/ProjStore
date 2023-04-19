namespace Models
{
    public class Store
    {
        public readonly static string INSERT = "insert into Store (Description, Address)" +
            "values (@Description, @Address)";

        public readonly static string GETALL = "select id, Description, Address from Store";
        public int Id { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this); //Vai transformar em uma string de Json
        }
    }
}