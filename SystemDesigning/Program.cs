// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace GitProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            GitClass GitClass = new();
            GitClass.GitMethod();
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
}