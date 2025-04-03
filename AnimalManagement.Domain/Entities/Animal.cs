namespace AnimalManagement.Domain.Entities
{
    public class Animal
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string IdentificationNumber { get; private set; } // Numer identyfikacyjny / kolczyk
        public string Species { get; private set; } // Gatunek
        public string Breed { get; private set; } // Rasa
        public DateTime BirthDate { get; private set; }
        //public Gender Gender { get; private set; } // Płeć (enum)
        public decimal Weight { get; private set; }
        public DateTime AcquisitionDate { get; private set; } // Data nabycia
        //public AcquisitionMethod AcquisitionMethod { get; private set; } // Metoda nabycia (enum: urodzony w gospodarstwie, zakupiony, itp.)
        public decimal PurchasePrice { get; private set; } // Cena zakupu (jeśli dotyczy)
        public string SupplierInfo { get; private set; } // Informacje o dostawcy (jeśli dotyczy)
        //public AnimalStatus Status { get; private set; } // Status (enum: aktywny, sprzedany, padły, itp.)
        public string Location { get; private set; } // Lokalizacja w gospodarstwie
        public string Notes { get; private set; } // Dodatkowe notatki
        public byte[] Photo { get; private set; } // Zdjęcie zwierzęcia

        // Relacje
        public Guid? ParentFemaleId { get; private set; }
        public Animal ParentFemale { get; private set; }
        public Guid? ParentMaleId { get; private set; }
        public Animal ParentMale { get; private set; }
        public ICollection<Animal> Offspring { get; private set; }
        //public ICollection<HealthRecord> HealthRecords { get; private set; }
        //public ICollection<FeedingSchedule> FeedingSchedules { get; private set; }
        //public ICollection<WeightRecord> WeightRecords { get; private set; }
        //public ICollection<AnimalGroup> Groups { get; private set; }

        // Metody biznesowe
        public void UpdateDetails(string breed, decimal weight, string location)
        {
            Breed = breed;
            Weight = weight;
            Location = location;
        }
        //public void ChangeStatus(AnimalStatus newStatus, string reason) { /* ... */ }
        public void RecordWeight(decimal weight, DateTime date) { /* ... */ }
        //public void AssignToGroup(AnimalGroup group) { /* ... */ }
        //public void RemoveFromGroup(AnimalGroup group) { /* ... */ }

    }
}
