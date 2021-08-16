namespace PetData
{
    public enum CatType{
        Abyssian, Persian, Himalayan, American_Bobtail, Balinese_Javanese, Bengal, Bombay,British_Shorthair
    }
    public class Cat:Pet
    {
        public CatType CatType { get; set; }
        public double Weight { get; set; }
    }
}