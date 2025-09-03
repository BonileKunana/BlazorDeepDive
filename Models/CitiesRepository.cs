namespace ServerManagement.Models
{
    public static class CitiesRepository
    {
        private static List<string> cities = new List<string>()
        {
            "Toronto",
            "Gqeberha",
            "Pretoria",
            "eGoli",
            "cape"
        };

        public static List<string> GetCities() => cities;

    }
}