namespace ShorIntegerFactorization {

    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Extensions.Math;
    open Microsoft.Quantum.Extensions.Convert;
    open Microsoft.Quantum.Canon;


    operation Set(desired : Result, q1: Qubit) : Unit
    {
        let current = M(q1);
        if(desired != current)
        {
            X(q1);
        }
    }

    operation find_period(gen : Int, N : Int, Mod : Int) : Int {

        let l = BitSize(Mod);
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

                    ModularMultiplyByConstantLE(ExpMod(gen,7,N),N,LittleEndian(fx));
                    InPlaceXorLE(1,LittleEndian(fx));
                    QFTLE(topRegisterLE);
                    mutable result = 5; //M(topRegisterLE);
                    for(i in 1..l){
                        Set(Zero,topRegister[i-1]);
                        //Set(Zero,topRegisterLE[i-1]);
                    }
                    for(i in 1..n){
                        Set(Zero,bottomRegister[i-1]);
                        //Set(Zero,topRegisterLE[i-1]);
                    }
                    return result;
                }

            }
        }


    }



}