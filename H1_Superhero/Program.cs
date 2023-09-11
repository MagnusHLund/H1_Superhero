using System.Reflection;

namespace H1_Superhero
{
    internal class Program
    {
        // Creates an array with 3 positions
        Superhero[] hero = new Superhero[3];

        void Superheroes()
        {
            // Assigns a new class "Superhero" to each of the positions in the hero array
            for(int i = 0; i < 3; i++)
            {
                hero[i] = new Superhero();
            }
            
            // Assigns values to each of the super heroes, by calling the properties
            hero[0].ActualName = "Bruce Wayne";
            hero[0].HeroName = "Batman";
            hero[0].Powers = "none";
            hero[0].HasSecretIdentity = true;
            hero[0].WearsCostume = true;
            hero[0].FightsAlone = false;
            hero[0].HasStrongMoralComplex = true;
            hero[0].HasNemesis = true;
            hero[0].HasPrivateAnxiety = false;

            hero[1].ActualName = "Peter Parker";
            hero[1].HeroName = "Spider-man";
            hero[1].Powers = "Spider-sense, biological webshooters"; // Tobey maguire's spider-man
            hero[1].HasSecretIdentity = true;
            hero[1].WearsCostume = true;
            hero[1].FightsAlone = true;
            hero[1].HasStrongMoralComplex = true;
            hero[1].HasNemesis = false;
            hero[1].HasPrivateAnxiety = true;

            hero[2].ActualName = "Diana Prince";
            hero[2].HeroName = "Wonder-Woman";
            hero[2].Powers = "Strong";
            hero[2].HasSecretIdentity = true;
            hero[2].WearsCostume = true;
            hero[2].FightsAlone = false;
            hero[2].HasStrongMoralComplex = false;
            hero[2].HasNemesis = false;
            hero[2].HasPrivateAnxiety = false;

            View();
        }

        void View()
        {
            // For loop to go through each hero in the hero array
            for (int i = 0; i < 3; i++)
            {
                // Checks each property for the hero in the array
                foreach (PropertyInfo info in hero[i].GetType().GetProperties())
                {
                    // This code outputs the name of the property, as well as the value
                    // We need to give "GetValue" our object, which is the class called "Superhero" because it is not part of the "memberInfo".
                    // This means that it cant figure out which object we want to call, by itself. Thats why it should be assigned, by using "hero[i]"
                    // The hero array contains our objects.
                    // GetValue finds a property, which matches with the PropertyInfo, inside the given object.
                    Console.WriteLine($"{info.Name}: {info.GetValue(hero[i])}");
                }

                // Creates a space
                Console.WriteLine();
            }

            static void Main()
            {
                // Calls the superheroes method, which is not static
                Program program = new Program();
                program.Superheroes();
            }
        }
    }
}