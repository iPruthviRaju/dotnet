Task vs Thread

Task: It doesn't create it's own operate system thread (we avoid wasting OS threads). 
Task is executed by a TaskScheduler and allows to return a result. Task represent some asynchronous operation through lightweight object for managing a parallelizable unit of work. .NET 4.0 and above.

Thread: It is used for creating and manipulating a thread in OS and allows us to fully control by using Resume, Abort or Suspend methods. Big disadvantages is time consume for create stage.