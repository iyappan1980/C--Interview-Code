using InterviewCode;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using Microsoft.Extensions.DependencyInjection;
using System;

public class HelloWorld
{
    public static void Main()
    {
        // Singleton Class - create one object of the class
        //SingletonClass objGetInstance = SingletonClass.GetInstance();
        //objGetInstance.SingletonMethod();
        //GenericClass objGenericClass = new GenericClass();
        //objGenericClass.objSingleton.SingletonMethod();

        // Singleton Class - create 2  object of the class
        //SingletonClassCount objGetCountInstance = SingletonClassCount.GetInstance();
        //objGetCountInstance.SingletonCountMethod();
        //GenericClassCount objGenericClassCount = new GenericClassCount();
        //objGenericClassCount.objSingletonCount1?.SingletonCountMethod();
        ////objGenericClassCount.objSingletonCount2?.SingletonCountMethod();
        //SingletonClassCount objGetCountInstances = SingletonClassCount.GetInstance();
        //objGetCountInstances?.SingletonCountMethod();

        // Threading        

        //Thread Thread3 = new Thread(new ThreadStart(obj.LockThreadDisplayMessage));
        //Thread Thread4 = new Thread(new ThreadStart(obj.LockThreadDisplayMessage));

        //Thread3.Start();
        //Thread4.Start();

        //Thread3.Join();
        //Thread4.Join();

        //Thread Thread1 = new Thread(new ThreadStart(obj.ThreadDisplayMessage));
        //Thread Thread2 = new Thread(new ThreadStart(obj.ThreadDisplayMessage));

        //Thread1.Start();
        //Thread2.Start();

        //Thread1.Join();
        //Thread2.Join();

        // Mutex
        //ThreadingClass threadingClass = ThreadingClass.GetInstance();
        //threadingClass.MutexThread();

        // Semaphore
        //ThreadingClass threadingClass = ThreadingClass.GetInstance();
        //threadingClass.SemaphoreThread(1);
        //threadingClass.SemaphoreThread(2);

        // Generic

        //GenericsMethod<string> genericsMethod = new GenericsMethod<string>();
        //genericsMethod.Add(0, "Kin");
        //genericsMethod.Add(1, "Star");
        //genericsMethod.Add(2, "Raji");
        //Console.WriteLine(genericsMethod.GetData(2));

        //DataStore<string> store = new DataStore<string>();
        //store.Data = "Hello Generic";
        ////store.Data = 100; // Compiler Error
        //Console.WriteLine(store.Data);

        //DataStore<int> storeInt = new DataStore<int>();
        //storeInt.Data = 100;
        ////storeInt.Data = "Hello Generic"; // Compiler Error

        //Console.WriteLine(storeInt.Data);

        //KeyValuePairClass<int,string> pair = new KeyValuePairClass<int,string>();
        //pair.Key = 100;
        //pair.Value = "hello";
        ////pair.Key = "hello"; // Compiler Error
        ////pair.Value = 100; // Compiler Error
        //Console.WriteLine(pair.Key + "  " + pair.Value);

        //KeyValuePairClass<string, string> pairString = new KeyValuePairClass<string, string>();
        //pairString.Key = "Hello";
        //pairString.Value = "hello";
        ////pairString.Key = 101; // Compiler Error
        ////pairString.Value = 100; // Compiler Error
        //Console.WriteLine(pairString.Key + "  " + pairString.Value);

        ////Generic Method in Non-generic Class
        //Printer printer = new Printer();
        //printer.Print<string>("String generics Printer");
        //printer.Print("String NON generics Printer");

        // IEnumerable
        //EnumerableClass enumerableClass = new EnumerableClass();
        //enumerableClass.GetAllCustomer();

        // LINQ
        //Student student = new Student();
        //student.GetStudentBook();

        ////Dependency Injuction Contructor
        //using Microsoft.Extensions.DependencyInjection;

        //var services = new ServiceCollection();
        //services.AddSingleton<ICustomer, Customer>();
        //services.AddTransient<DependencyInjConstructor>();

        //var serviceProvider = services.BuildServiceProvider();

        //var processor = serviceProvider.GetService<DependencyInjConstructor>();
        //processor?.GetProcessCustomer("Hello Dependency Inj Constructor !");

        ////Dependency Injuction Property
        //using Microsoft.Extensions.DependencyInjection;

        //var services = new ServiceCollection();
        //services.AddSingleton<ICustomer, Customer>();
        //services.AddTransient<DependencyInjProperty>();

        //var serviceProvider = services.BuildServiceProvider();

        //var propertyInjectedProcessor = new DependencyInjProperty
        //{
        //    objCust = serviceProvider.GetService<ICustomer>()
        //};

        //propertyInjectedProcessor.GetProcessCustomer("Hello from Property Injection!");

        ////Dependency Injuction Method
        //using Microsoft.Extensions.DependencyInjection;

        //var services = new ServiceCollection();
        //services.AddSingleton<ICustomer, Customer>();
        //services.AddTransient<MethodInjectedProcessor>();

        //var serviceProvider = services.BuildServiceProvider();

        //var methodInjectedProcessor = new MethodInjectedProcessor();
        //var messageService = serviceProvider.GetService<ICustomer>();

        //methodInjectedProcessor.Process("Hello from Method Injection!", messageService);

        /// Cards Suffle
        //Deck deck = new Deck();
        /////deck.SuffleSingleMethod();
        //deck.Suffle();
        //for (int i = 0; i < 52; i++)
        //{
        //    Console.WriteLine(deck.DealCard());
        //    if ((i + 1) % 4 == 0)
        //        Console.WriteLine();
        //}
        //Console.ReadLine();

        /// Find Roman Numerals
        //RomanNumerals.FindRomanNumerals("Iyappan got great Victory");
        //RomanNumerals.ConvertRomanNumeralToInteger("XXIV");


        /// Product Of Array Except Self
        //int[] inputVal = {5, 4, 3, 2, 6};
        //ProductOfArrayExceptSelf.ProductExceptSelf_AlternateSolution(inputVal);
        //ProductOfArrayExceptSelf.ProductExceptSelf(inputVal);

        /// Calculate High Scores
        //List<int> list = new List<int>() { 4, 2, 3, 2, 0, 1, 2, 2, 1, 3, 0, 2, 2, 0, 1, 5 };
        //string result = CalculateHighScore.CalculateHighScoreData(2, 4, list);
        //Console.WriteLine(result);
        //Dictionary<string,int> keyValuePairs = new Dictionary<string,int>();
        //var before = GC.GetTotalMemory(true);
        //Console.WriteLine(before);
        //keyValuePairs.Add("abcdefghijk",100);
        //var after = GC.GetTotalMemory(true);
        //var used = before - after;
        //Console.WriteLine(after);
        //Console.WriteLine(used);
        //keyValuePairs.Add("bcdefghijk", 100);
        //keyValuePairs.Add("bbcdefghijk", 100);
        //keyValuePairs.Add("bccdefghijk", 100);
        //keyValuePairs.Add("bdcdefghijk", 100);
        //keyValuePairs.Add("adcdefghijk", 100);
        //keyValuePairs.Add("abdcdefghijk", 100);
        //after = GC.GetTotalMemory(true);
        //used = before - after;
        //Console.WriteLine(after);
        //Console.WriteLine(used);

        OpenAI.CallOpenAI();
    }
    //public static async Task Main()
    //{
    //    // Threading
    //    ThreadingClass obj = ThreadingClass.GetInstance();
    //    await obj.AsyncFunction();
    //}
}
