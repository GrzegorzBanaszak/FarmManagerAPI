using System;

namespace AnimalManagement.Domain.ValueObjects;
//Szczegóły hodowlane
public class BreedingDetails
{
    public string Pedigree { get; private set; } // Rodowód
    public string LineageInfo { get; private set; } // Informacje o linii hodowlanej
    public bool IsPurebreed { get; private set; } // Czy czystorasowy
    public string RegistrationNumber { get; private set; } // Numer rejestracyjny
    public string GeneticTraits { get; private set; } // Cechy genetyczne

    public BreedingDetails(string pedigree, string lineageInfo, bool isPurebreed, string registrationNumber, string geneticTraits)
    {
        Pedigree = pedigree;
        LineageInfo = lineageInfo;
        IsPurebreed = isPurebreed;
        RegistrationNumber = registrationNumber;
        GeneticTraits = geneticTraits;
    }
}
