using System;

namespace PetData
{
    public enum Gender
    {
        Male, Female
    }
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime Dob { get; set; }
    }
}
