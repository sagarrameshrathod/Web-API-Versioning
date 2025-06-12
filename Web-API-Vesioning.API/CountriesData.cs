using Web_API_Vesioning.API.Model.Domian;

namespace Web_API_Vesioning.API
{
    public static class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[]
            {
                new {Id = 1, Name = "India"},
                new {Id = 2, Name = "Brazil"},
                new {Id = 3, Name = "Russia"},
                new {Id = 4, Name = "Germany"},
                new {Id = 5, Name = "Japan"},
                new {Id = 6, Name = "Italy"}
            };
            return countries.Select(c => new Country {Id = c.Id, Name = c.Name}).ToList();
        }
    }
}
