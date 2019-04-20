#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShorIntegerFactorization\",\"Name\":\"Set\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"desired\"]},\"Type\":{\"Case\":\"Result\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":15},\"Item2\":{\"Line\":1,\"Column\":22}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"q1\"]},\"Type\":{\"Case\":\"Qubit\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":35}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Result\"},{\"Case\":\"Qubit\"}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShorIntegerFactorization\",\"Name\":\"Set\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs\",\"Position\":{\"Item1\":8,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":14}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"ShorIntegerFactorization\",\"Name\":\"find_period\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"gen\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":23},\"Item2\":{\"Line\":1,\"Column\":26}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"N\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":34},\"Item2\":{\"Line\":1,\"Column\":35}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"Mod\"]},\"Type\":{\"Case\":\"Int\"},\"IsMutable\":false,\"HasLocalQuantumDependency\":false,\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":46}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"Int\"},{\"Case\":\"Int\"},{\"Case\":\"Int\"}]]},\"ReturnType\":{\"Case\":\"Int\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"ShorIntegerFactorization\",\"Name\":\"find_period\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs\",\"Position\":{\"Item1\":17,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
#line hidden
namespace ShorIntegerFactorization
{
    public class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "ShorIntegerFactorization.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in__) =>
        {
            var (desired,q1) = __in__;
#line 11 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
            var current = M.Apply(q1);
#line 12 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
            if ((desired != current))
            {
#line 14 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                MicrosoftQuantumPrimitiveX.Apply(q1);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class find_period : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public find_period(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "find_period";
        String ICallable.FullName => "ShorIntegerFactorization.find_period";
        protected ICallable<Int64, Int64> MicrosoftQuantumCanonBitSize
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> MicrosoftQuantumCanonExpMod
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonInPlaceXorLE
        {
            get;
            set;
        }

        protected IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonModularMultiplyByConstantLE
        {
            get;
            set;
        }

        protected IUnitary<Microsoft.Quantum.Canon.LittleEndian> MicrosoftQuantumCanonQFTLE
        {
            get;
            set;
        }

        protected Allocate Allocate
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<(Int64,Int64,Int64), Int64> Body => (__in__) =>
        {
            var (gen,N,Mod) = __in__;
#line 20 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
            var l = MicrosoftQuantumCanonBitSize.Apply(Mod);
#line 21 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
            var n = MicrosoftQuantumCanonBitSize.Apply(N);
#line hidden
            {
#line 22 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                var topRegister = Allocate.Apply(l);
#line hidden
                Exception __arg1__ = null;
                try
                {
#line 24 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                    foreach (var i in new Range(1L, l))
#line hidden
                    {
#line 26 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                        Set.Apply((Result.Zero, topRegister[(i - 1L)]));
                    }

#line hidden
                    {
#line 28 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                        var bottomRegister = Allocate.Apply(n);
#line hidden
                        Exception __arg3__ = null;
                        try
                        {
#line hidden
                            {
#line 30 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                var fx = Allocate.Apply(n);
#line hidden
                                Exception __arg5__ = null;
                                try
                                {
#line 32 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    foreach (var i in new Range(1L, n))
#line hidden
                                    {
#line 34 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                        Set.Apply((Result.Zero, bottomRegister[(i - 1L)]));
                                    }

#line 36 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    var topRegisterLE = new Microsoft.Quantum.Canon.LittleEndian(topRegister?.Copy());
#line 37 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    var bottomRegisterLE = new Microsoft.Quantum.Canon.LittleEndian(bottomRegister?.Copy());
#line 38 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    MicrosoftQuantumCanonQFTLE.Apply(topRegisterLE);
#line 40 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    MicrosoftQuantumCanonModularMultiplyByConstantLE.Apply((MicrosoftQuantumCanonExpMod.Apply((gen, 7L, N)), N, new Microsoft.Quantum.Canon.LittleEndian(fx?.Copy())));
#line 41 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    MicrosoftQuantumCanonInPlaceXorLE.Apply((1L, new Microsoft.Quantum.Canon.LittleEndian(fx?.Copy())));
#line 42 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    MicrosoftQuantumCanonQFTLE.Apply(topRegisterLE);
#line 43 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    var result = 5L;
#line 44 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    foreach (var i in new Range(1L, l))
#line hidden
                                    {
#line 45 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                        Set.Apply((Result.Zero, topRegister[(i - 1L)]));
                                    }

#line 48 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    foreach (var i in new Range(1L, n))
#line hidden
                                    {
#line 49 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                        Set.Apply((Result.Zero, bottomRegister[(i - 1L)]));
                                    }

#line 52 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Shor/Shor.qs"
                                    return result;
                                }
#line hidden
                                catch (Exception __arg6__)
                                {
                                    __arg5__ = __arg6__;
                                    throw __arg5__;
                                }
#line hidden
                                finally
                                {
                                    if (__arg5__ != null)
                                    {
                                        throw __arg5__;
                                    }

#line hidden
                                    Release.Apply(fx);
                                }
                            }
                        }
#line hidden
                        catch (Exception __arg4__)
                        {
                            __arg3__ = __arg4__;
                            throw __arg3__;
                        }
#line hidden
                        finally
                        {
                            if (__arg3__ != null)
                            {
                                throw __arg3__;
                            }

#line hidden
                            Release.Apply(bottomRegister);
                        }
                    }
                }
#line hidden
                catch (Exception __arg2__)
                {
                    __arg1__ = __arg2__;
                    throw __arg1__;
                }
#line hidden
                finally
                {
                    if (__arg1__ != null)
                    {
                        throw __arg1__;
                    }

#line hidden
                    Release.Apply(topRegister);
                }
            }
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonBitSize = this.Factory.Get<ICallable<Int64, Int64>>(typeof(Microsoft.Quantum.Canon.BitSize));
            this.MicrosoftQuantumCanonExpMod = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Microsoft.Quantum.Canon.ExpMod));
            this.MicrosoftQuantumCanonInPlaceXorLE = this.Factory.Get<IUnitary<(Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.InPlaceXorLE));
            this.MicrosoftQuantumCanonModularMultiplyByConstantLE = this.Factory.Get<IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularMultiplyByConstantLE));
            this.MicrosoftQuantumCanonQFTLE = this.Factory.Get<IUnitary<Microsoft.Quantum.Canon.LittleEndian>>(typeof(Microsoft.Quantum.Canon.QFTLE));
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Set));
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 gen, Int64 N, Int64 Mod)
        {
            return __m__.Run<find_period, (Int64,Int64,Int64), Int64>((gen, N, Mod));
        }
    }
}