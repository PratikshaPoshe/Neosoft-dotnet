using System;
namespace PetLib
{
    /// <summary>
    /// This component of the class contains behaviors/methods
    /// </summary>
    public abstract partial class Pet
    {
        /// <summary>
        /// This method returns the formatted string with all details of a pet, name, id, gender, dob
        /// </summary>
        /// <returns>string</returns>
        public string GetDetails()
        {
            return $"without any params Pet name : {name}\n Pet ID: {id}\n Pet Birthday : {dob.ToShortDateString()}\n Pet Gender : {gender}"; 
        } 
        public string GetDetails(string name ="Feline"){
            return $"With string param Pet name : {this.name =name}\n Pet ID: {id}\n Pet Birthday : {dob.ToShortDateString()}\n Pet Gender : {gender}"; 
        }
        public string GetDetails(string name, int id){
            return $" Pet name : {this.name =name}\n Pet ID: {this.id =id}\n Pet Birthday : {dob.ToShortDateString()}\n Pet Gender : {gender}"; 
        }
        public string GetDetails(string name, int id, DateTime dob){
            return $" Pet name : {this.name =name}\n Pet ID: {id}\n Pet Birthday : {this.dob=dob}\n Pet Gender : {gender}"; 
        }
        public string GetDetails(string name, int id, DateTime dob, Gender gender){
            return $" Pet name : {this.name =name}\n Pet ID: {id}\n Pet Birthday : {this.dob=dob}\n Pet Gender : {this.gender=gender}"; 
        }
        public partial void Partial_Method();
       public abstract void GetMeal(Gender gender);
        // public virtual void GetMeal(Gender gender){
        //     if(gender == Gender.Male){
        //         Console.Write("\n200 gms of wet food");
        //     }
        //     else
        //         Console.Write("\n125 gms of wet food");
        // }
    }
}