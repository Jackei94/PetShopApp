using System;
using System.Collections.Generic;
using PetShopApp.Core.Entity;

namespace PetShopApp.Core.DomainService
{
    public interface IPetRepository
    {
        //PetRepository Interface
        //Create Data
        Pet Create(Pet pet);
        //Read Data
        Pet ReadById(int id);
        IEnumerable<Pet> ReadAll();
        //Update Data
        Pet Update(Pet petUpdate);
        //Delete Data
        Pet Delete(int id);
    }
}
