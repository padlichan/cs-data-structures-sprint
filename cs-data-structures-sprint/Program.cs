// Console.WriteLine("Your code can go here, if you like");
using cs_data_structures_sprint.Exercises;
using cs_data_structures_sprint.RequestBenchmark;

LinkedList<string> cars = new LinkedList<string>();
cars.AddLast("Ford");
cars.AddLast("Kia");
cars.AddLast("BMW");
cars.AddLast("Lexus");
cars.AddLast("Skoda");
cars.AddLast("Mercedes");
cars.AddLast("Nissan");
cars.AddAfter(cars.Find("Ford"), "Ferrari");
//foreach(string car in cars)
//{
//    Console.WriteLine(car);
//}
Exercise3.SwapElementPosition(cars, 2, 6);
Console.WriteLine();
//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}


//Exercise2.PrintFirstAndLast(cars);
LinkedList<int> numbers = new();
numbers.AddLast(22);
numbers.AddFirst(5);
numbers.AddLast(66);
numbers.AddFirst(95);
//Exercise2.PrintFirstAndLastGeneric(numbers);
//Exercise1.PrintExesAndOhs(5);

//LinkedList<Car> newCars  = new();
//newCars.AddLast(new Car("Ford", "Mustang", 2003));
//newCars.AddLast(new Car("Ford", "Focus", 2019));
//newCars.AddLast(new Car("Nissan", "Murano", 1988));
//newCars.AddLast(new Car("BMW", "M", 1999));
////Exercise2.PrintFirstAndLastGeneric(newCars);

//var andrea = new Student("1", "Andrea");
//Exercise4.GradeStudent(andrea, 17);
//Console.WriteLine(Exercise4.CheckGrade(andrea)); // should return 17

//var andrew = new Student("2", "Andrew");
//Console.WriteLine(Exercise4.CheckGrade(andrew));
//Exercise4.UpdateGrade(andrew, 5);
//Console.WriteLine(Exercise4.CheckGrade(andrew));

//Exercise4.UpdateGradeBook(andrew, "English", 2);


//Console.WriteLine(Exercise4.gradeBook["2"]["English"]);

//Console.WriteLine(Exercise5.StackReverseWord("C# is wonderful!"));
int[] nums = [5, 10, 15, 20, 25, 30]; 
Queue<int> queue = new Queue<int>(nums);
//Exercise6.PrintQueue(queue);

string[] peopleNames = ["Sam", "Poppy", "Leo", "Lili"];
Queue<string> people = new Queue<string>(peopleNames);

//Exercise6.ReverseQueue(people);


PerformBenchmark.Start("Dictionary", new RequestDictionary(), 100000);

PerformBenchmark.Start("SortedDictionary", new RequestSortedDictionary(), 100000);