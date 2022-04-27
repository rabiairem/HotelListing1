namespace HotelListing.Models
{
    public class HotelDTO : CreateCountyDTO
    {
        public int Id { get; set; }

        public CountryDTO Country { get; set; }
    }
}
