using PetShopApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShopApp.Core.ApplicationService
{
    public interface IPetService
    {
        //New Pet
        Pet NewPet(string name, string type, DateTime birthdate, DateTime soldTime, string color, string previousOwner, double price);

        //Create
        Pet CreatePet(Pet pet);

        //Read
        Pet FindPetById(int id);

        List<Pet> GetAllPets();

        List<Pet> GetAllByName(string name);

        //Update
        Pet UpdatePet(Pet petUpdate);

        //Delete
        void DeletePet(int id);

    }
}
