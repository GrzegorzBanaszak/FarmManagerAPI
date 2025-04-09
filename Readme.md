#### Farm Manager API

Aplikacja do zarządzania gospodarstwem rolnym udostepniająca kompleksowe rozwiązania wspomagające zarządzanie gospodarstwem.

### Spis treści

- [Opis](#-opis)
- [Technologie](#technologie)
- [Funkcje aplikacji](#-funkcje-aplikacji)

## 📝 Opis

Celem projektu jest stworzenie interfejsu API umożliwiającego kompleksowe zarządzanie gospodarstwem rolnym. Aplikacja zapewnia funkcjonalności wspierające codzienne operacje, usprawniając organizację pracy oraz monitorowanie zasobów.

## 🚀 Funkcje aplikacji

- **Zarządzanie zwierzętami** – ewidencja, monitorowanie zdrowia, harmonogramy karmienia.
- **Zarządzanie polami** – rejestracja upraw, planowanie zasiewów, monitorowanie plonów, monitorowanie pogody.
- **Zarządzanie pracownikami** – lista pracowników, harmonogramy pracy,tworzenie zadań, role i uprawnienia.
- **Zarządzanie maszynami** – ewidencja sprzętu, harmonogramy konserwacji, historia napraw.
- **Zarządzanie powiadomieniami** – automatyczne alerty i przypomnienia o ważnych wydarzeniach.
- **Autoryzacja i uwierzytelnianie** – bezpieczny dostęp do systemu z wykorzystaniem mechanizmów logowania i kontroli uprawnień.

Aplikacja została zaprojektowana z myślą o łatwej integracji z innymi systemami oraz skalowalności, co pozwala na jej dalszy rozwój zgodnie z potrzebami użytkowników.

### Technologie

- ASP.NET
- Microservices
- Docker
- Kubernetes (Minikube)
- RabbitMQ
- Mycrosoft SQL Server
- Entity Framework Core
- Swagger
- JWT

## Struktura projektu

```
FarmManagement/
│
├── src/
│   ├── BuildingBlocks/                      # Wspólne komponenty
│   │   ├── EventBus/                        # Implementacja szyny zdarzeń
│   │   ├── Infrastructure/                  # Współdzielona infrastruktura
│   │   └── Common/                          # Wspólne modele, interfejsy, itp.
│   │
│   ├── Services/
│   │   ├── Identity/                        # Mikroserwis uwierzytelniania i autoryzacji
│   │   │   ├── Identity.API/
│   │   │   ├── Identity.Domain/
│   │   │   ├── Identity.Infrastructure/
│   │   │   └── Identity.Tests/
│   │   │
│   │   ├── AnimalManagement/                # Mikroserwis zarządzania zwierzętami
│   │   │   ├── AnimalManagement.API/
│   │   │   ├── AnimalManagement.Domain/
│   │   │   ├── AnimalManagement.Infrastructure/
│   │   │   └── AnimalManagement.Tests/
│   │   │
│   │   ├── FieldManagement/                 # Mikroserwis zarządzania polami
│   │   │   ├── FieldManagement.API/
│   │   │   ├── FieldManagement.Domain/
│   │   │   ├── FieldManagement.Infrastructure/
│   │   │   └── FieldManagement.Tests/
│   │   │
│   │   ├── EmployeeManagement/              # Mikroserwis zarządzania pracownikami
│   │   │   ├── EmployeeManagement.API/
│   │   │   ├── EmployeeManagement.Domain/
│   │   │   ├── EmployeeManagement.Infrastructure/
│   │   │   └── EmployeeManagement.Tests/
│   │   │
│   │   ├── MachineManagement/               # Mikroserwis zarządzania maszynami
│   │   │   ├── MachineManagement.API/
│   │   │   ├── MachineManagement.Domain/
│   │   │   ├── MachineManagement.Infrastructure/
│   │   │   └── MachineManagement.Tests/
│   │   │
│   │   └── NotificationService/             # Mikroserwis powiadomień
│   │       ├── NotificationService.API/
│   │       ├── NotificationService.Domain/
│   │       ├── NotificationService.Infrastructure/
│   │       └── NotificationService.Tests/
│   │
│   ├── ApiGateways/
│   │   ├── Web.BFF/                         # API Gateway dla aplikacji webowej
│   │   └── Mobile.BFF/                      # API Gateway dla aplikacji mobilnej
│   │
│   └── Web/
│       ├── WebApp/                          # Aplikacja webowa (SPA)
│       └── WebStatus/                       # Dashboard monitorujący statusy mikroserwisów
│
├── deploy/
│   ├── docker/                              # Konfiguracje Docker
│   │   └── docker-compose.yml
│   └── kubernetes/                          # Konfiguracje Kubernetes (opcjonalnie)
│
└── docs/                                    # Dokumentacja projektu

```

## Zarzażądzanie zwierzetami

[Link relacji](https://dbdiagram.io/d/AnimalManagement-67eebbe04f7afba1844330f7)
