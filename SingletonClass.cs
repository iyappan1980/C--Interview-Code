using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;

namespace InterviewCode
{   
    public class SingletonClass
    {
        private static SingletonClass? obj = null;
        private SingletonClass() { }
        public static SingletonClass GetInstance()
        {
            if (obj == null)
            {
                obj = new SingletonClass();
                Console.WriteLine("Singleton Class Created");
            }
            return obj;
        }
        public void SingletonMethod()
        {
            Console.WriteLine("Hellow World");
        }
    }
    public class GenericClass
    {
        public SingletonClass objSingleton;
        public GenericClass()
        {
            objSingleton = SingletonClass.GetInstance();
        }
    }

    public class SingletonClassCount
    {
        private static SingletonClassCount? obj = null;
        private static int ClassCount = 1;
        private SingletonClassCount() { }
        public static SingletonClassCount GetInstance()
        {
            if (obj == null || ClassCount <= 2)
            {
                obj = new SingletonClassCount();
                Console.WriteLine("Singleton Class Created");                
                Console.WriteLine("Singleton Class Count" + ClassCount);
                ClassCount++;
            }
            else {
                Console.WriteLine("Maximum object reached");
                return null; 
            }
            return obj;
        }
        public void SingletonCountMethod()
        {
            Console.WriteLine("Hellow World");
        }
    }

    public class GenericClassCount
    {
        public SingletonClassCount objSingletonCount1;
        public SingletonClassCount objSingletonCount2;
        public GenericClassCount()
        {
            objSingletonCount1 = SingletonClassCount.GetInstance();
            objSingletonCount2 = SingletonClassCount.GetInstance();
        }
    }
    /*
     public class HelloWorld
{
    
    public static void Main(string[] args)
    {
        var refObj = SigletonClass.GetInstance();
        var refObj1 = SigletonClass.GetInstance();
        var refObj2 = SigletonClass.GetInstance();
    }
    
    public static async Task Main1(string[] args)
    {
        var refObj = SigletonClass.GetInstance();
        await refObj.CallMultiThread();
    }
}

public class SigletonClass
{
private SigletonClass(){}
private static SigletonClass obj = null;
private static int objCount = 1;
public static SigletonClass GetInstance(){
    if(obj == null || objCount <= 2){
        obj = new SigletonClass();
         Console.WriteLine("Hello Singleton Count " + objCount);
         objCount +=1;
    }
    else{
        Console.WriteLine("Reached max object");
        return null;
    }
    return obj;
}

private object lockObj = new object();
public void LockTread(){
    lock(lockObj){
        Console.WriteLine("Welcome to " );
        Thread.Sleep(10000);
        Console.WriteLine("lock thread workld" );
    }
    }
public void NormalTread(){
        Console.WriteLine("Welcome to " );
        Thread.Sleep(10000);
        Console.WriteLine("Normal thread workld" );
}

public async Task CallMultiThread()
{
    await Task.Run(()=>{
        LockTread();
        NormalTread();
    });
}
}




     */



}



