# Singleton Pattern

## What is Singleton?
Ensure that a class has just a single instance
Provide a global access point to that instance

## Why do we use it?
1.Add a private static field to the class for storing the singleton instance. (private static SingletonClass _instance)

2.Declare a public static creation method for getting the singleton instance.(public static SignletonClass GetInstance(){})

3.Implement “lazy initialization” inside the static method. 
(Check is the object exist? yes return that object, if no, create object [before creating object ,better to lock object for multi thread safe])
It should create a new object on its first call and put it into the static field. 

4.Make the constructor of the class private. The static method of the class will still be able to call the constructor, but not the other objects.
(private SingletonObject(){})

## Advantages
You can be sure that a class has only a single instance

## Disadvantages
Violates the single responsibility principle.
It may be difficult to unit test because many test framework relys on inheritance when producing mock objects
