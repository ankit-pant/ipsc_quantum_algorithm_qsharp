namespace ShorIntegerFactorization {
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;
    open Micorosoft.Quantum.Canon;


    operation Set(desired : Result, q1: Qubit) : Unit
    {
        let current = M(q1);
        if(desired != current)
        {
            X(q1);
        }
    }

    operation find_period(gen : Int, N : Int, M : Int) : Int {

        let l = BitSize(M);
        let n = BitSize(N);
        using (topRegister = Qubit[l])
        {
            for(i in 1..l)
            {
                Set(Zero, topRegister[i-1]);
            }
            using (bottomRegister = Qubit[n])
            {
                using (fx = Qubit[n])
                {
                    for(i in 1..n)
                    {
                        Set(Zero, bottomRegister[i-1]);
                    }
                    let topRegisterLE = LittleEndian(topRegister);
                    let bottomRegisterLE = LittleEndian(bottomRegister);
                    QFTLE(topRegisterLE);

                    ModularMultiplyByConstantLE(ExMod(gen,topRegisterLE,N),N,LittleEndian(fx));
                    InplaceXorLE(bottomRegisterLE,fx);
                    QFTLE(topRegisterLE);
                    let result = M(topRegisterLE);
                    return result;
                }

            }
        }


    }



}