using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int commandCount = int.Parse(Console.ReadLine());

        List<Pet> pets = new List<Pet>();
        List<PetClinic> clinics = new List<PetClinic>();

        for (int i = 0; i < commandCount; i++)
        {
            string[] commandInput = Console.ReadLine().Split();
            string command = commandInput[0];

            switch (command)
            {
                case "Create":
                    try
                    {
                        string typeOfCreation = commandInput[1];
                        if (typeOfCreation == "Pet")
                        {
                            string name = commandInput[2];
                            int age = int.Parse(commandInput[3]);
                            string kind = commandInput[4];

                            Pet pet = new Pet(name, age, kind);
                            pets.Add(pet);
                        }
                        else
                        {
                            string name = commandInput[2];
                            int roomCount = int.Parse(commandInput[3]);
                            PetClinic clinic = new PetClinic(name, roomCount);
                            clinics.Add(clinic);
                        }
                    }
                    catch (InvalidOperationException invalidOperationException)
                    {
                        Console.WriteLine(invalidOperationException.Message);
                    }
                    break;
                case "Add":
                    Pet petToAdd = pets.FirstOrDefault(p => p.Name == commandInput[1]);
                    PetClinic clinicToAdd = clinics.FirstOrDefault(c => c.Name == commandInput[2]);
                    Console.WriteLine(clinicToAdd.Add(petToAdd));
                    break;
                case "Release":
                    PetClinic clinicToRelease = clinics.FirstOrDefault(c => c.Name == commandInput[1]);
                    Console.WriteLine(clinicToRelease.Release());
                    break;
                case "HasEmptyRooms":
                    PetClinic clinicToCheck = clinics.FirstOrDefault(c => c.Name == commandInput[1]);
                    Console.WriteLine(clinicToCheck.HasEmptyRooms);
                    break;
                case "Print":
                    PetClinic clinicToPrint = clinics.FirstOrDefault(c => c.Name == commandInput[1]);
                    if (commandInput.Length == 3)
                    {
                        int roomNumber = int.Parse(commandInput[2]);
                        Console.WriteLine(clinicToPrint.Print(roomNumber));
                    }
                    else
                    {
                        Console.WriteLine(clinicToPrint.PrintAll());
                    }
                    break;
            }
        }
    }
}

