using System;

using CPUx86 = XSharp.Assembler.x86;

namespace Cosmos.IL2CPU.X86.IL
{
    [Cosmos.IL2CPU.OpCode(ILOpCode.Code.Ret)]
    public class Ret : ILOp
    {
        public Ret(XSharp.Assembler.Assembler aAsmblr) : base(aAsmblr)
        {
        }

        public override void Execute(_MethodInfo aMethod, ILOpCode aOpCode)
        {
            //TODO: Return
            Jump_End(aMethod);
            // Need to jump to end of method. Assembler can emit this label for now
            //XS.Jump(MethodFooterOp.EndOfMethodLabelNameNormal);
        }
    }
}
