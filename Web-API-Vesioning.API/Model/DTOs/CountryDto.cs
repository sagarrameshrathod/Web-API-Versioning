﻿namespace Web_API_Vesioning.API.Model.DTOs
{
    public class CountryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CountryDtoV2
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}
