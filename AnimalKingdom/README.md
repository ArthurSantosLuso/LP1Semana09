```mermaid
classDiagram

    class Program

    class Animal

    class Dog

    class Cat

    class Bat

    class Bee
    
    class IMammal{
        <<interface>>
    } 

    class ICanFly{
        <<interface>>
    } 

    Animal <|-- Bat
    Animal <|-- Bee
    Animal <|-- Dog
    Animal <|-- Cat
    Dog ..|> IMammal
    Cat ..|> IMammal
    Bat ..|> IMammal
    Bee ..|> ICanFly
    Bat ..|> ICanFly


    
