// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using SystemDesigning;

namespace GitProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Calculations calculations = new Calculations();
            calculations.Add();
        }
    }
    class GitClass
    {
        int GitID { get; set; }
        string GitName { get; set; }

        public void GitMethod()
        {
            Console.WriteLine("Git method added");
        }
    }
    public class GitClassBranch
    {
    }
}