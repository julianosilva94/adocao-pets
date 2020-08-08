using System;

namespace PetAdoption.Domain.Entities
{
    public class Pet : Entity
    {
        public Pet(string name, string sex, string location)
        {
            Name = name;
            Sex = sex;
            Location = location;
            Adopted = false;
        }

        public string Name { get; private set; }
        public string Sex { get; private set; }
        public string Location { get; private set; }
        public bool Adopted { get; private set; }

        public void MarkAsAdopted()
        {
            Adopted = true;
        }
    }
}