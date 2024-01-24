using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.WorkFlowEngine
{
    public class NotifyOwner : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Notify owner");
        }
    }
}
