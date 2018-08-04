SOLID principles
  These are the design principles that enable us manange most of the software design problems.

S: Single Responsibility Principle (SRP)
O: Open Closed Principle (OSP)
L: Liskov Substitution Principle (LSP)
I: Interface Segregation Principle (ISP)
D: Dependency Inversion Principle (DIP)

Single Responsibility Principle (SRP):
- A class should have only one reason to change.
- Every module or class should have responsibilty over a single part of the functionality provided by the software, and that responsibility should be entirely encapsulated by the class.

Advantages:
- Maintainability
- Testability
- Flexibility and Extensibility
- Parallel Development
- Loose coupling

Open Closed Principle (OCP):
- Software entities such as classes, modules, functions, etc. should be open for extension, but closed for modification.
- Any new functionality should be implemented by added new classed, attributes and methods, instead of changing the current ones or existing ones.
- The simplest way to apply OCP is to implement the new functionality on new derived classes.
- Allow clients to access the original class with abstract interface.

Interface Segregation Principle (ISP):
- No client should be forced to depend on methods it does not use.
- One fat interface should be slited to many smaller and relevant interfaces so that clients can know about the interfaces that are relevant to them.
