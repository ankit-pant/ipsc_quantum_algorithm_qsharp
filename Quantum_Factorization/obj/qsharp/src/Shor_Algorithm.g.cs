#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"find_Period\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"SupportedFunctors\":[]},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"Parent\":{\"Namespace\":\"Quantum_Factorization\",\"Name\":\"find_Period\"},\"SourceFile\":\"/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs\",\"Position\":{\"Item1\":5,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":22}},\"Documentation\":[]}")]
#line hidden
namespace Quantum_Factorization
{
    public class find_Period : Operation<QVoid, QVoid>, ICallable
    {
        public find_Period(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "find_Period";
        String ICallable.FullName => "Quantum_Factorization.find_Period";
        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in__) =>
        {
#line 7 "/home/maven/Sem_II/IPSC/Project/Repository/ipsc_quantum_algorithm_qsharp/Quantum_Factorization/Shor_Algorithm.qs"
            Message.Apply("Hello quantum world!");
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<find_Period, QVoid, QVoid>(QVoid.Instance);
        }
    }
}