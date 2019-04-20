using System;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Core;

namespace ShorIntegerFactorization {
    class Shor_Program {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                long N = 15;
                long M = 16;
                long G = 2;
                long res = find_period.Run(qsim, G, N, M).Result;
                Console.WriteLine(res);
                Console.ReadKey();
            }   
        }
    }
}