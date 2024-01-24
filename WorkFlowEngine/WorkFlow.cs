using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeC_.WorkFlowEngine
{
    public class WorkFlow : IWorkFlow

    {
        private readonly List<IActivity> _activities;
        public WorkFlow()
        {
            _activities = new List<IActivity>();
        }
        public void Add(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }

}