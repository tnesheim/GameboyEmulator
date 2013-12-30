using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameboyEmulator
{
    class GameboyCPU
    {
        private byte stackPtr;
        private byte programCnt;

        public enum OPCodes
        { 
            NOP,
            LD_BC_nn,
            LD_BC_A,
            INC_BC,
            INC_B,
            DEC_B,
            LD_B_n,
            RLC_A,
            LD_nn_SP,
            ADD_HL_BC,
            LD_A_BC,
            DEC_BC,
            INC_C,
            DEC_C,
            LD_C_N,
            RRC_A,
            /*2nd Line: STOP*/
        }

        /*Property to access the current value of the stack pointer*/
        public byte StackPointer
        {
            get
            {
                return stackPtr;
            }
        }

        /*Property to access the current value of the program counter*/
        public byte ProgramCounter
        {
            get
            {
                return programCnt;
            }
        }
    }
}
