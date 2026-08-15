# Factory Method Pattern
# Learn material
https://refactoring.guru/design-patterns/factory-method

## What is Factory Method?
-creational design pattern
-provides an interface for creating obj in a superclass
 but allows subclasses to alter the type of objs that will be created

# When do we use it?
1.Project like logistic, baking (there will be a lot of new types of objects in the future)
2.Libray or framework claas

## How to implement?
1. Make all products follow the same interface.This interface should declare methods that make sense in every prodcut

2.Add an empty factory method inside the creator class.
The return type of the method should match the common product interface that created in step1.

3.create a set of creator subclasses that extends parent creator class created in step2
and override the factory method and retun obj of product that 
extends interface class in step 1

4.create product class that extends interface class in step 1

5. in client code, create obj by calling step 3 class 
so client don't know whick product obj is created

## Advantages
-supports the single responsiblity priciple,
because the product creation code into one place
-can create new types of products into the program
without breaking exsisting client code
-reduce coupling.
## Disadvantages
codes may become more complicated