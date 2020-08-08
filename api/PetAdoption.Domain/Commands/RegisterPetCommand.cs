using Flunt.Notifications;
using PetAdoption.Domain.Commands.Contracts;

namespace PetAdoption.Domain.Commands
{
    public class RegisterPetCommand : Notifiable, ICommand
    {
        public RegisterPetCommand() { }

        public RegisterPetCommand(string name, string sex, string location)
        {
            Name = name;
            Sex = sex;
            Location = location;
        }

        public string Name { get; set; }
        public string Sex { get; set; }
        public string Location { get; set; }
        
        public void Validate()
        {
        }
    }
}