using homework_week_4;
using homework_week_4.exercise_1;
using homework_week_4.exercise_2;
using homework_week_4.exercise_3;
using homework_week_4.exercise_4;
using homework_week_4.exercise_5;
using homework_week_4.exercise_6;
using homework_week_4.exercise_7;
using homework_week_4.exercise_8;

//exercise 0/1
BirthdayCalendar Ana = new BirthdayCalendar("Ana Maria", "Popescu", 12, 10, 1986);
Console.WriteLine (Ana.CompleteName());

//exercise 0/2
Books amintiri = new Books("Amintiri din copilarie ", "Ion Creanga", 1881, 120);
Console.WriteLine(amintiri.BookDescription());

//exercise 0/3
Events jazz = new Events();
jazz.nameEvent = "Jazz party";
jazz.location = "Bucharest";
jazz.dayOfEvent = 18;
jazz.monthOfEvent = "April";
jazz.yearOfEvent = 2024;
Console.WriteLine(jazz.EventInformation());

//exercise 0/4
Flowers tulip = new Flowers();
tulip.flowerName = " Tulip Normandis";
tulip.plantingMonth = "September";
tulip.floweringSeason = "March";
tulip.price = 100;
Console.WriteLine(tulip.price);
tulip.SetPrice(52);
tulip.GrowPrice(tulip.price);
Console.WriteLine(tulip.price);
//exercise0/5
Movie poppins = new Movie();
poppins.name = "Marry Poppins return";
poppins.type = "Comedy";
poppins.year = 1970;
poppins.raiting = 15;
poppins.GetRaiting(30);
Console.WriteLine(poppins.raiting);
poppins.IncreaseRaiting();
Console.WriteLine(poppins.raiting);
//exercise 1
Crop cornflake = new Crop();
cornflake.name = "cornflake";
Console.WriteLine(cornflake.currentStage);
cornflake.Water();
Console.WriteLine(cornflake.currentStage);
cornflake.Water();
Console.WriteLine(cornflake.currentStage);
cornflake.Water();
Console.WriteLine(cornflake.currentStage); 
cornflake.Water();
Console.WriteLine(cornflake.currentStage);
cornflake.Harvest();
Console.WriteLine(cornflake.currentStage);
// exercise 2
Farm rock = new Farm();
rock.farmName = "New Rock";
rock.area = 100;
rock.AddAnimals(40);
rock.AddAnimals(20);
Console.WriteLine("animal count "+rock.animalCount);
Console.WriteLine("Density"+ rock.CalculateDensity());
//exercise 3
Book book = new Book("War and Peace", "Leo Tolstoy", 1869);
Console.WriteLine(book.GetTitle()); // Outputs "War and Peace"
Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
Console.WriteLine(book.GetYear()); // Outputs 1869
book.SetTitle("Anna Karenina");
book.SetAuthor("Leo Tolstoy");
book.SetYear(1877);
Console.WriteLine(book.GetTitle()); // Outputs "Anna Karenina"
Console.WriteLine(book.GetAuthor()); // Outputs "Leo Tolstoy"
Console.WriteLine(book.GetYear()); // Outputs 1877*/
//exercise 4
Product product = new Product("Apple", 0.99, 10);
Console.WriteLine(product.GetName()); // Outputs "Apple"
Console.WriteLine(product.GetPrice()); // Outputs 0.99
Console.WriteLine(product.GetQuantity()); // Outputs 10
product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);
Console.WriteLine(product.GetName()); // Outputs "Orange"
Console.WriteLine(product.GetPrice()); // Outputs 1.49
Console.WriteLine(product.GetQuantity()); // Outputs 20*/
//exercise 5
Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);
Console.WriteLine(animal.GetName()); // Outputs "Max"
Console.WriteLine(animal.GetSpecies()); // Outputs "Dog"
Console.WriteLine(animal.GetBreed()); // Outputs "Labrador Retriever"
Console.WriteLine(animal.GetAge()); // Outputs 2
Console.WriteLine(animal.GetColor()); // Outputs "Yellow"
Console.WriteLine(animal.GetWeight()); // Outputs 75
Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs true
animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);
Console.WriteLine(animal.GetName()); // Outputs "Buddy"
Console.WriteLine(animal.GetSpecies()); // Outputs "Cat"
Console.WriteLine(animal.GetBreed()); // Outputs "Siamese"
Console.WriteLine(animal.GetAge()); // Outputs 5
Console.WriteLine(animal.GetColor()); // Outputs "Gray"
Console.WriteLine(animal.GetWeight()); // Outputs 12
Console.WriteLine(animal.IsSpayedOrNeutered()); // Outputs false*/
//exercise 6
Calculator calculator = new Calculator();
Console.WriteLine(calculator.Add(2, 3)); // Outputs 5
Console.WriteLine(calculator.Subtract(5, 2)); // Outputs 3
Console.WriteLine(calculator.Multiply(3, 4)); // Outputs 12
Console.WriteLine(calculator.Divide(10, 5)); // Outputs 2
Console.WriteLine(calculator.Power(2, 3)); // Outputs 8
Console.WriteLine(calculator.SquareRoot(9)); // Outputs 3*/
//exercise 7

University myUniversity = new University("My University");

homework_week_4.exercise_7.Student john = new homework_week_4.exercise_7.Student("John", "Doe", 123456, 3.8);
homework_week_4.exercise_7.Student jane = new homework_week_4.exercise_7.Student("Jane", "Smith", 654321, 3.6);

myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);

Faculty mary = new Faculty("Mary", "Jones", 111111, ["Math", "Physics"]);
Faculty bob = new Faculty("Bob", "Smith", 222222, ["English", "History"]);

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount()); // Outputs 2
Console.WriteLine(myUniversity.GetFacultyCount()); // Outputs 2


//exercise 8

College myCollege = new College();

homework_week_4.exercise_8.Student joe = new homework_week_4.exercise_8.Student();
homework_week_4.exercise_8.Student janet = new homework_week_4.exercise_8.Student();
