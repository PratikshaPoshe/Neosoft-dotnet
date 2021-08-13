namespace PetLib
{
    public interface IPet
    {
        int Id { get; set; }
        Gender Gender { get; set; }
        string Name { get; set; }
        System.DateTime Dob { get; set; }
        string GetDetails();
    }
}