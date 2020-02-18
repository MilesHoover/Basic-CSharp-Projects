using System;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main()
        {
            string one = "Hello, ";
            string two = "my name is ";
            string three = "Miles.";
            string sentence = one + two + three;
            Console.WriteLine(sentence);

            string upperSentence = sentence.ToUpper();
            Console.WriteLine(upperSentence);

            StringBuilder sb = new StringBuilder();
            sb.Append("Quantum Computing is the use of quantum-mechanical phenomena such as superposition and entanglement to perform computation. ");
            sb.Append("A quantum computer is used to perform such computation, which can be implemented theoretically or physically. ");
            sb.Append("There are two main approaches to physically implementing a quantum computer currently, analog and digital. ");
            sb.Append("Analog approaches are further divided into quantum simulation, quantum annealing, and adiabatic quantum computation.");
            sb.Append("Digital quantum computers use quantum logic gates to do computation. ");
            sb.Append("Both approaches use quantum bits or qubits.");
            Console.WriteLine(sb);

            Console.ReadLine();
        }
    }
}
