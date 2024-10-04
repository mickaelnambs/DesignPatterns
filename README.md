# Design Patterns in C#

This project demonstrates various design patterns implemented in C#. It serves as a learning resource and reference for understanding and applying common software design patterns.

## Project Structure

The project is organized into separate classes for each design pattern, with a main program that allows you to run demonstrations of each pattern.

## Implemented Patterns

- Factory
- Decorator
- Builder
- Prototype
- Bridge
- Adapter
- Singleton

Each pattern is implemented in its own class that inherits from the `IPatternExample` interface.

## How to Run

1. Clone the repository
2. Open the solution in Visual Studio or your preferred C# IDE
3. Build the solution
4. Run the program

When you run the program, you'll be presented with a menu of available design patterns. Choose a pattern to see its demonstration.

## Pattern Descriptions

### Factory
The Factory pattern provides an interface for creating objects in a superclass, allowing subclasses to decide which class to instantiate.

### Decorator
The Decorator pattern allows behavior to be added to individual objects, either statically or dynamically, without affecting the behavior of other objects from the same class.

### Builder
The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create various representations.

### Prototype
The Prototype pattern allows you to copy existing objects without making your code dependent on their classes.

### Bridge
The Bridge pattern lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.

### Adapter
The Adapter pattern allows objects with incompatible interfaces to collaborate.

### Singleton
The Singleton pattern ensures a class has only one instance and provides a global point of access to it.

## Contributing

Feel free to fork this project and add your own implementations of design patterns. Pull requests for new patterns or improvements to existing implementations are welcome!
