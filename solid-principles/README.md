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

Implementation Guidelines:
- The simplest way to apply OCP is to implement the new functionality on new derived classes.
- Allow clients to access the original class with abstract interface.

Without OCP:
- End up testing the entire functionality
- QA team need to test the entire flow.
- Costly process for the organization.
- Breaks the Single Responsibility Principle as well.
- Maintenance overheads increase on the classes.

Liskov Substitution Principle (LSP):
- S is subtype of T, then objects of type T may be replaced with objects of type S
- Derived types must be completely substitutable for their base types.
- Liskov Substitution Principle (LSP) is a particular definition of a subtyping relation called (strong) behavioral subtyping.
- Extension for the Open Closed Principle.

Implementation Guidelines:
- No new exceptions can be thrown by the subtype.
- Clients should not know which specific subtype they are calling.
- New derived classes just extend without replacing the functionality of old classes.

Interface Segregation Principle (ISP):
- No client should be forced to depend on methods it does not use.
- One fat interface should be slited to many smaller and relevant interfaces so that clients can know about the interfaces that are relevant to them.
