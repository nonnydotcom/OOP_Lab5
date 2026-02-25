**ชานนท์ บุบปับพา 683450353-3**

---

# Training Registration System (ระบบรับสมัครฝึกอบรม)

โปรแกรมสำหรับลงทะเบียนฝึกอบรม พัฒนาด้วยภาษา C# โดยประยุกต์ใช้หลักการ Object-Oriented Programming (OOP) ตรงตามข้อกำหนดของโจทย์ดังนี้:
- **Abstract Class:** ใช้สำหรับคลาส `User` เพื่อเป็นแม่แบบเก็บข้อมูลพื้นฐานของทุกคน 
- **Interface:** ใช้สร้างความสามารถเพิ่มเติม เช่น `IMember` (สำหรับการลงทะเบียน) และ `ISpeaker` (สำหรับวิทยากรในการอบรมและอนุมัติผล)
- **Class:** มีคลาส `Student`, `Teacher`, และ `Guest` ที่สืบทอดจาก User และคลาส `TrainingCourse` สำหรับจัดการข้อมูลในระบบ

## Class Diagram

```mermaid
classDiagram
    class User {
        <<abstract>>
        #string firstname
        #string lastname
        #string phone
        #string email
        +SetUserInfo(firstname, lastname, phone, email)
        +ShowDetails()*
    }

    class IMember {
        <<interface>>
        +Register()
    }

    class ISpeaker {
        <<interface>>
        +Train()
        +Approve()
    }

    class Student {
        -string major
        -string studentId
        +SetStudentInfo(major, studentId)
        +Register()
        +ShowDetails()
    }

    class Teacher {
        -string major
        -string academicPosition
        +SetTeacherInfo(major, academicPosition)
        +Register()
        +Train()
        +Approve()
        +ShowDetails()
    }

    class Guest {
        -string workplace
        -string jobPosition
        +SetGuestInfo(workplace, jobPosition)
        +Register()
        +Train()
        +Approve()
        +ShowDetails()
    }

    class TrainingCourse {
        -List~User~ attendees
        -List~ISpeaker~ speakers
        +AddAttendee(user: User)
        +AddSpeaker(speaker: ISpeaker)
        +ShowAllAttendees()
        +ShowAllSpeakers()
    }

    %% Relationships
    User <|-- Student
    IMember <|.. Student
    
    User <|-- Teacher
    IMember <|.. Teacher
    ISpeaker <|.. Teacher
    
    User <|-- Guest
    IMember <|.. Guest
    ISpeaker <|.. Guest

    TrainingCourse o-- User
    TrainingCourse o-- ISpeaker
