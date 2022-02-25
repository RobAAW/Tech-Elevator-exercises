using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Classes;

namespace VendingMachine.DAO
{
    public interface IDAO
    {
        Dictionary<string, Queue<VendingMachineItem>> LoadMachine(string filePath);
        void LogTransaction(string action, decimal txAmount, decimal currentBalance);
        void ResetLog();

    }
}
