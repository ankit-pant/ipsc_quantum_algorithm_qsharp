# Implementing Shor's Algorithm on a Quantum Computer Simulation

This project involves implementing Shor's algorithm, that is used to factorize integers (generally large primes). 

The project was implemented using Q# using Microsoft's Quantum Development Kit. The driver code was written in C#.

It involved writing a Quantum Subroutine that exploits the periodicity of generator (of a group) to probabilistically find a candidate that is the factor of the input integer. The code was then run in a Quantum simulator (provided by Quantum Development Kit).

A brief description of the files and directories in the repository is given below:

- **Quantum_Factorization:** This directory contains the source code (in Q# and C#).
- **Project_Report.pdf:** This file contains a detailed report of the project involving the pseudocode for both the classical and quantum algorithm.
- **README.md:** This file contains a brief description of the project.
