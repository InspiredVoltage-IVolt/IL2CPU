using System;


namespace Cosmos.IL2CPU.X86.IL
{
	[Cosmos.IL2CPU.OpCode(ILOpCode.Code.Refanytype)]
	public class Refanytype: ILOp
	{
		public Refanytype(XSharp.Assembler.Assembler aAsmblr):base(aAsmblr)
		{
		}

    public override void Execute(_MethodInfo aMethod, ILOpCode aOpCode) {
      throw new NotImplementedException();
    }

    
		// using System;
		// using System.IO;
		// 
		// 
		// using CPU = XSharp.Assembler.x86;
		// 
		// namespace Cosmos.IL2CPU.IL.X86 {
		// 	[XSharp.Assembler.OpCode(OpCodeEnum.Refanytype)]
		// 	public class Refanytype: Op {
		// 		public Refanytype(ILReader aReader, MethodInformation aMethodInfo)
		// 			: base(aReader, aMethodInfo) {
		// 		}
		// 		public override void DoAssemble() {
		// //			Pop("eax");
		// //			Pushd("[eax]");
		// 		}
		// 	}
		// }
		
	}
}
