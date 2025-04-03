using System;

namespace AnimalManagement.Domain.ValueObjects;


//Identyfikacja zwierzęcia
public class AnimalIdentification
{
    public string Number { get; private set; } // Numer identyfikacyjny
    public IdentificationType Type { get; private set; } // Typ identyfikacji (chip, kolczyk, itp.)
    public DateTime IssuedDate { get; private set; } // Data wydania
    public string IssuedBy { get; private set; } // Wydane przez

    public AnimalIdentification(string number, IdentificationType type, DateTime issuedDate, string issuedBy)
    {
        Number = number;
        Type = type;
        IssuedDate = issuedDate;
        IssuedBy = issuedBy;
    }

    public enum IdentificationType
    {
        EarTag,
        Microchip,
        BrandMark,
        TattooMark,
        Other
    }
}
