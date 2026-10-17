
using System;
using Assignment_7;
class Program
{
    static void Main()
    {
        #region Question 1 - Car Constructors

        // Question:
        // Create a Car class with Id, Brand, and Price.
        // Create objects using different constructors.

        // Answer:
        // A custom constructor initializes an object with specific values.
        // When we define a constructor, the compiler does not provide
        // the default parameterless constructor automatically.

        //Car car1 = new Car();
        //Car car2 = new Car(1);
        //Car car3 = new Car(2, "BMW");
        //Car car4 = new Car(3, "BMW", 500000);

        //Console.WriteLine(car1);
        //Console.WriteLine(car2);
        //Console.WriteLine(car3);
        //Console.WriteLine(car4);

        #endregion

        #region Question 2 - Method Overloading

        // Question:
        // Create overloaded Sum methods for two integers,
        // three integers, and two doubles.

        // Answer:
        // Overloading improves readability and reusability
        // by allowing methods to share the same name.

        //Calculator calculator = new Calculator();

        //Console.WriteLine(calculator.Sum(10, 20));
        //Console.WriteLine(calculator.Sum(10, 20, 30));
        //Console.WriteLine(calculator.Sum(10.5, 20.5));

        #endregion

        #region Question 3 - Constructor Chaining

        // Question:
        // Create Parent with X and Y.
        // Create Child with Z and call the Parent constructor.

        // Answer:
        // Constructor chaining reuses the base constructor
        // to initialize inherited properties.

        // Child child = new Child(10, 20, 30);
        //
        // Console.WriteLine($"X = {child.X}");
        // Console.WriteLine($"Y = {child.Y}");
        // Console.WriteLine($"Z = {child.Z}");

        #endregion

        #region Question 4 - new vs override

        // Question:
        // Demonstrate method hiding using new and overriding
        // using override.

        // Answer:
        // new hides the base method.
        // override changes the virtual method behavior at runtime.

        // ChildNew childNew = new ChildNew(2, 3, 4);
        // Parent parentWithNew = childNew;
        //
        // Console.WriteLine(childNew.Product());       // 24
        // Console.WriteLine(parentWithNew.Product());  // 6
        //
        // ChildOverride childOverride =
        //     new ChildOverride(2, 3, 4);
        //
        // Parent parentWithOverride = childOverride;
        //
        // Console.WriteLine(childOverride.Product());      // 24
        // Console.WriteLine(parentWithOverride.Product()); // 24

        #endregion

        #region Question 5 - ToString and Polymorphism

        // Question:
        // Override ToString in Parent and Child.

        // Answer:
        // Overriding ToString provides a readable representation
        // of an object.

        // Parent parent = new Parent(10, 20);
        // Child child = new Child(10, 20, 30);
        //
        // Console.WriteLine(parent.ToString());
        // Console.WriteLine(child.ToString());
        //
        // Parent parentReference = child;
        // Console.WriteLine(parentReference.ToString());

        #endregion

        #region Question 6 - Interface IShape

        // Question:
        // Create IShape with Area and Draw.
        // Implement it in Rectangle.

        // Answer:
        // An interface cannot be instantiated directly because
        // it defines a contract for implementing classes.

        // IShape rectangle = new Rectangle(5, 4);
        //
        // Console.WriteLine($"Area = {rectangle.Area}");
        // rectangle.Draw();

        #endregion

        #region Question 7 - Default Interface Method

        // Question:
        // Add PrintDetails as a default interface method.
        // Implement IShape in Circle and call PrintDetails.

        // Answer:
        // Default interface methods allow interfaces to provide
        // implementations without requiring every class
        // to implement the new method.

        // Circle circle = new Circle(5);
        // IShape shape = circle;
        //
        // shape.PrintDetails();

        #endregion

        #region Question 8 - Interface Reference

        // Question:
        // Create IMovable with Move and implement it in Car.

        // Answer:
        // An interface reference allows different classes
        // implementing the same interface to be used consistently.

        // IMovable movable = new Car(1, "Honda", 200000);
        // movable.Move();

        #endregion

        #region Question 9 - Multiple Interfaces

        // Question:
        // Create IReadable and IWritable.
        // Implement both interfaces in File.

        // Answer:
        // A class can implement multiple interfaces,
        // even though it cannot inherit from multiple classes.

        // File file = new File();
        // file.Read();
        // file.Write();

        #endregion

        #region Question 10 - Abstract Class

        // Question:
        // Create abstract Shape with virtual Draw and abstract
        // CalculateArea. Implement both in Rectangle.

        // Answer:
        // virtual provides a method implementation that can be overridden.
        // abstract declares a method without an implementation
        // that a concrete derived class must implement.

        // Shape shape = new Rectangle(6, 3);
        //
        // shape.Draw();
        // Console.WriteLine($"Area = {shape.CalculateArea()}");

        #endregion

        #region Part 02 - Question 1: Class vs Struct

        // Question:
        // What is the difference between class and struct?

        // Answer:
        // A class is a reference type, while a struct is a value type.
        // A class can inherit from another class, but a struct
        // cannot inherit from another class or struct.

        #endregion

        #region Part 02 - Question 2: Class Relationships

        // Question:
        // What are other relationships between classes besides inheritance?

        // Answer:
        // Other relationships include association, aggregation,
        // and composition.

        #endregion

        #region Part 03 - Bonus: Self Study Report

        // Question:
        // Write a self-study report about the assigned OOP topics.

        // Answer:
        // The report should summarize the studied concepts,
        // explain what was learned, and include examples where needed.

        #endregion

        #region Part 03 - Bonus: Static vs Dynamic Binding

        // Question:
        // What is the difference between static and dynamic binding?

        // Answer:
        // Static binding is resolved at compile time.
        // Dynamic binding is resolved at runtime, such as when
        // an overridden virtual method is called through a base reference.

        #endregion
    }
}
