namespace SGS.BusinessLayer.DTOs
{
    public class CurrencyDTO
    {
        public string ID { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; } 
        public string Name { get; set; }
        public int Nominal { get; set; }
        public double Value { get; set; }
        public double Previous { get; set; }
    }
}
