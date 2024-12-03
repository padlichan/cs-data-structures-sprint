// Console.WriteLine("Your code can go here, if you like");
using cs_data_structures_sprint.Exercises;
LinkedList<string> cars = new LinkedList<string>();
cars.AddLast("Ford");
cars.AddLast("Kia");
cars.AddLast("BMW");
cars.AddLast("Lexus");
cars.AddLast("Skoda");
cars.AddLast("Mercedes");
cars.AddLast("Nissan");
cars.AddAfter(cars.Find("Ford"), "Ferrari");

//Exercise2.PrintFirstAndLast(cars);
LinkedList<int> numbers = new();
numbers.AddLast(22);
numbers.AddFirst(5);
numbers.AddLast(66);
numbers.AddFirst(95);
//Exercise2.PrintFirstAndLastGeneric(numbers);
//Exercise1.PrintExesAndOhs(5);

LinkedList<Car> newCars  = new();
newCars.AddLast(new Car("Ford", "Mustang", 2003));
newCars.AddLast(new Car("Ford", "Focus", 2019));
newCars.AddLast(new Car("Nissan", "Murano", 1988));
newCars.AddLast(new Car("BMW", "M", 1999));
Exercise2.PrintFirstAndLastGeneric(newCars);
