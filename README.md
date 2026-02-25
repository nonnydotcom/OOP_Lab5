classDiagram

%% =========================
%% Abstract Class
%% =========================
class Person {
    <<abstract>>
    - string FirstName
    - string LastName
    - string Phone
    - string Email
    + string GetFullName()
    + void DisplayInfo()*
}

%% =========================
%% Interfaces
%% =========================
class ISpeaker {
    <<interface>>
    + void ConductTraining()
    + void ApproveResult(Person p)
}

class IMember {
    <<interface>>
    + void Register()
}

%% =========================
%% Sub Classes
%% =========================
class Student {
    - string StudentId
    - string Major
    + void DisplayInfo()
    + void Register()
}

class Lecturer {
    - string Major
    - string AcademicPosition
    + void DisplayInfo()
    + void Register()
    + void ConductTraining()
    + void ApproveResult(Person p)
}

class GeneralPerson {
    - string Workplace
    - string Position
    + void DisplayInfo()
    + void Register()
    + void ConductTraining()
    + void ApproveResult(Person p)
}

%% =========================
%% Training System
%% =========================
class TrainingSystem {
    - List~Person~ participants
    - List~ISpeaker~ speakers
    + void AddParticipant(Person p)
    + void AddSpeaker(ISpeaker s)
    + void ShowParticipants()
    + void ShowSpeakers()
}

%% =========================
%% Relationships
%% =========================

Person <|-- Student
Person <|-- Lecturer
Person <|-- GeneralPerson

IMember <|.. Student
IMember <|.. Lecturer
IMember <|.. GeneralPerson

ISpeaker <|.. Lecturer
ISpeaker <|.. GeneralPerson

TrainingSystem o-- Person
TrainingSystem o-- ISpeaker
