Test Driven Development:
- It is thought process where we'll write test cases before developing.
- Fail -> Pass -> Refactor

- Step 1: Write a test caes and fail it.
- Step 2: Put enough code to pass it.
- Step 3: Refactor
- Step 4: Run test case Pass/Fail -> Step 3

Advantages:
- Intentions are clear, you understand the requirement well.
- Iterative development and testing
- Catching defects early
- Enforce developer to write test cases.
- Documentation

Difference between AreEqual and AreSame

The difference between the two assertions are quite simple. Assert.AreSame checks that they are the exact same object, memory reference and all (in the case of .NET using ReferenceEquals). Assert.AreEqual checks that objectOne.Equals(objectTwo) will return true.

Here’s a simple example of how they will work with a sensible implementation of Equals.

    1 public class Example

    2 {

    3     private int variable;

    4 

    5     public Example(int variable)

    6     {

    7         this.variable = variable;

    8     }

    9 

   10     public override bool Equals(object obj)

   11     {

   12         if (obj is Example)

   13             return Equals(obj as Example);

   14 

   15         return base.Equals(obj);

   16     }

   17 

   18     private bool Equals(Example obj)

   19     {

   20         return variable == obj.variable;

   21     }

   22 }

   23 

   24 [TestFixture]

   25 public class Test

   26 {

   27     [Test]

   28     public void ExampleTest()

   29     {

   30         var one = new Example(1);

   31         var two = new Example(1);

   32         var three = new Example(2);

   33         var four = one;

   34 

   35         Assert.AreEqual(one, two);   // true

   36         Assert.AreSame(one, two);    // false

   37         Assert.AreEqual(two, three); // false

   38         Assert.AreSame(two, three);  // false

   39         Assert.AreEqual(one, four);  // true

   40         Assert.AreSame(one, four);   // true

   41     }

   42 }

So long as you have a sensible Equals method that compares the values of the two objects you can follow these rules:

If two objects are the same, they will be equal
If two objects are equal, they may not be the same
If two objects are not equal, they will not be the same
