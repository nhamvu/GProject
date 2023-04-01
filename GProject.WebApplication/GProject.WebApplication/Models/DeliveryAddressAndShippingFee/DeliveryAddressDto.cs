namespace GProject.WebApplication.Models.DeliveryAddressAndShippingFee
{
    public class DeliveryAddressDto
    {
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public int DistrictID { get; set; }
        public string DistrictName { get; set; }
        public string WardCode { get; set; }
        public string WardName { get; set; }
    }
}
