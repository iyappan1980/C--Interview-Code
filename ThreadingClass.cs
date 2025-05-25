using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    public class ThreadingClass
    {
        private static ThreadingClass? obj = null;
        private ThreadingClass() { }
        public static ThreadingClass GetInstance()
        {
            if(obj == null) { 
                obj = new ThreadingClass();
            }
            return obj;
        }

        private object lockThread = new object();
        public void LockThreadDisplayMessage()
        {
            lock (lockThread)
            {
                Console.WriteLine("[Welcome to the");
                Thread.Sleep(1000);
                Console.WriteLine(".Net world]");
            }
        }

        public void ThreadDisplayMessage()
        {           
                Console.WriteLine("[Welcome to the");
                Thread.Sleep(1000);
                Console.WriteLine(".Net world]");
        }

        public  async Task AsyncFunction()
        {
            await Task.Run(() => { 
                LockThreadDisplayMessage();
                ThreadDisplayMessage();
            });
        }

        public void MutexThread()
        {
            // Mutex ensures that only one thread can access a shared resource at a time. Example: API Service is shared resouces called by many http request

            Mutex mutex = new Mutex();
            mutex.WaitOne();
            try
            {
                // Access shared resource
                Console.WriteLine("Mutex");
                Thread.Sleep(1000);
                Console.WriteLine("Thread");
            }
            catch (Exception) { }
            finally { mutex.ReleaseMutex(); }

        }
        public void SemaphoreThread(int count)
        {
            // Semaphore can be used when multiple threads are allowed to access the resource, but with a limited number of instances. Example: API Service is shared resouces called by many http request

            Semaphore semaphore = new Semaphore(1,2);
            semaphore.WaitOne();
            try
            {
                // Access shared resource
                Console.WriteLine("Semaphore " + count);
                Thread.Sleep(10000);
                Console.WriteLine("Thread");
            }
            catch (Exception) { }
            finally { semaphore.Release(); }

        }

        public void ReaderWriterLockSlim()
        {
            // ReaderWriterLockSlim allows multiple concurrent readers when no writer holds the lock and exclusive access for writer(s). Example: API Service is shared resouces called by many http request

            ReaderWriterLockSlim rwLock = new ReaderWriterLockSlim();
            // Read access
            rwLock.EnterReadLock();
            try
            {
                // Access shared resource
                Console.WriteLine("ReaderWriterLockSlim " );
                Thread.Sleep(10000);
                Console.WriteLine("Thread");
            }
            finally
            {
                rwLock.ExitReadLock();
            }
            //...
            // Write access
            rwLock.EnterWriteLock();
            try
            {
                // Access shared resource
            }
            finally
            {
                rwLock.ExitWriteLock();
            }
        }

        public void SpinLock()
        {
            // A low-level synchronization primitive that keeps trying to acquire the lock until successful. SpinLock should be used in low-contention scenarios, where the lock is expected to be held for a very short time. Example:

            SpinLock spinLock = new SpinLock();
            bool lockTaken = false;
            //...
            spinLock.Enter(ref lockTaken);
            try
            {
                // Access shared resource
            }
            finally
            {
                if (lockTaken)
                {
                    spinLock.Exit();
                }
            }
        }

        //private object lockThread1 = new object();
        //public  static async void LockThreadDisplayMessage1()
        //{
        //    lock (lockThread1)
        //    {
        //        Console.WriteLine("[Welcome to the");
        //        Thread.Sleep(1000);
        //        Console.WriteLine(".Net world]");
        //    }
        //}

        //public static async void ThreadDisplayMessage1()
        //{
        //    Console.WriteLine("[Welcome to the");
        //    Thread.Sleep(1000);
        //    Console.WriteLine(".Net world]");
        //}
    }
}
