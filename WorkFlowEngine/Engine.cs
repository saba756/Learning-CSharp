using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.WorkFlowEngine
{
    public class Engine
    {
        
        public void Run(IWorkFlow workFlow) { 

            foreach (IActivity item in workFlow.GetActivities()) {
               item.Execute();
            }
        } 
    }
}
