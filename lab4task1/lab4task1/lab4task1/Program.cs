using System;
using System.Runtime.InteropServices;

namespace lab4
{
    [StructLayout(LayoutKind.Sequential)]
    struct SystemInformation
    {
        public ushort wProcessorArchitecture;
        public ushort wReserved;
        public uint dwPageSize;
        public IntPtr lpMinimumAppAddress;
        public IntPtr lpMaximumAppAddress;
        public IntPtr dwActiveProcessorMask;
        public uint dwNumberOfProcessors;
        public uint dwProcessorType;
        public uint dwAllocationGranularity;
        public ushort wProcessorLevel;
        public ushort wProcessorRevision;
    }

    class Program
    {
        void ProcType(uint procType)
        {
            switch (procType)
            {
                case 386:
                    Console.WriteLine("Intel 386, 32-bit");
                    break;

                case 486:
                    Console.WriteLine("Intel 486, 32-bit");
                    break;

                case 586:
                    Console.WriteLine("Intel Pentium, 64-bit");
                    break;

                case 2200:
                    Console.WriteLine("Intel IA64, 64-bit");
                    break;

                case 8664:
                    Console.WriteLine("AMD X8664, 64-bit");
                    break;

                default:
                    Console.WriteLine("ARM, 64-bit");
                    break;
            }
        }

        [DllImport("kernel32.dll")]
        static extern void GetNativeSystemInfo(out SystemInformation SystInf);
        [DllImport("kernel32.dll")]
        static extern void GetPhysicallyInstalledSystemMemory(out long RAM);

        static void Main(string[] args)
        {
            SystemInformation SystInf;
            GetNativeSystemInfo(out SystInf);
            GetPhysicallyInstalledSystemMemory(out long RAM);
            string s = "        ";
            Console.WriteLine("System information :\n\n    Processor information :");
            Console.Write(s + "Processor type : ");
            switch (SystInf.dwProcessorType)
            {
                case 386:
                    Console.WriteLine("Intel 386, 32-bit");
                    break;

                case 486:
                    Console.WriteLine("Intel 486, 32-bit");
                    break;

                case 586:
                    Console.WriteLine("Intel Pentium, 64-bit");
                    break;

                case 2200:
                    Console.WriteLine("Intel IA64, 64-bit");
                    break;

                case 8664:
                    Console.WriteLine("AMD X8664, 64-bit");
                    break;

                default:
                    Console.WriteLine("ARM, 64-bit");
                    break;
            }

            Console.Write(s + "Processor architecture : ");

            switch (SystInf.wProcessorArchitecture)
            {
                case 0:
                    Console.WriteLine("x86");
                    break;

                case 5:
                    Console.WriteLine("ARM");
                    break;

                case 6:
                    Console.WriteLine("Intel Itanium-based");
                    break;

                case 9:
                    Console.WriteLine("x64(AMD or Intel)");
                    break;

                case 12:
                    Console.WriteLine("ARM64");
                    break;

                default:
                    Console.WriteLine("Unknown architecture");
                    break;
            }

            Console.WriteLine(s + $"Number of processors : {SystInf.dwNumberOfProcessors}");
            Console.WriteLine(s + $"Processor level : {SystInf.wProcessorLevel}");
            Console.WriteLine(s + $"Processor revision : {SystInf.wProcessorRevision}");
            Console.WriteLine(s + $"Reserved : {SystInf.wReserved}");
            Console.WriteLine(s + $"Page size : {SystInf.dwPageSize}");
            Console.WriteLine(s + $"Minimum application adress : {SystInf.lpMinimumAppAddress}");
            Console.WriteLine(s + $"Maximum application adress : {SystInf.lpMaximumAppAddress}");
            Console.WriteLine(s + $"Active processor mask : {SystInf.dwActiveProcessorMask}");
            Console.WriteLine(s + $"Allocation granularity : {SystInf.dwAllocationGranularity}");
            Console.WriteLine("\n    RAM information :");
            Console.WriteLine(s + $"Amount of RAM : {RAM / 1024 / 1024} GB");

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
