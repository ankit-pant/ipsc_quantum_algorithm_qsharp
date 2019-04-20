using System;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Simulation.Core;

namespace ShorIntegerFactorization {
    class Shor {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                int N = 15;
                int M = 16;
                res = find_period.Run(qsim, N, M).Result;
                System.LoaderOptimization.WriteLine(res);
                Console.ReadKey();
            }   
        }
    }
}