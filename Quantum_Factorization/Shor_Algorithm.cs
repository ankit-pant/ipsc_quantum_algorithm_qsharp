using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum_Factorization
{
    class Shor_Algorithm
    {
        private static int Calculate_GCD(int a, int N){
            int rem = 0;
            while(a!=0){
                rem = N%a;
                N = a;
                a = rem;
            }
            return N;
        }

        private static int Calculate_Pow(int a, int r){
            int pow = a%N;
            return pow;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This programs takes a composite number as an input and outputs its 2 non-trivial factors");
            Console.WriteLine("Enter a number (value of N):");
            int N = Convert.ToInt32(Console.ReadLine());
            if(N%2==0){
                Console.WriteLine("Since entered number is even, it has a trivial factor 2");
                int temp = N/2;
                Console.WriteLine("The other factor is "+temp);
                return;
            }
            //Choosing a random number. Since the probability of choosing a suitable random number is >1/2. Running for N/2 trials.
            int iterations = (int)Math.Ceiling((N/2.0));
            long period;
            for (int iter =0;iter<iterations;iter++){
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Iteration #"+(iter+1)+":");
                Random rand_gen = new Random();
                int a = rand_gen.Next(2,N);
                Console.WriteLine("Random number generated is "+a);
                int gcd = Calculate_GCD(a,N);
                Console.WriteLine("Calculated GCD is "+gcd);
                if(gcd>1){
                    Console.WriteLine("The randomly chosen number " + a + " is not co-prime to "+N);
                    Console.WriteLine("Hence the factors of " + N + " are: " + gcd + " " +  (N/gcd));
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine();
                    return;
                }
                using (var qsim = new QuantumSimulator())
                {
                    period = find_Period.Run(qsim).Result;
                    Console.WriteLine("The period for " + a + " is " + period);
                }
                if(period%2==0){
                    Console.WriteLine("This iteration of Shor's algorithm failed. Trying again...");
                    Console.WriteLine("---------------------------------------------------------");
                    Console.WriteLine();
                    continue;
                }
                a_exp_r = Calculate_Pow(a,period);
                

            }
            
        }
    }
}