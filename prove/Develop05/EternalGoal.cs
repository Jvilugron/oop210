using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    class EternalGoal : Goal
    {
        private int reward;

        public EternalGoal(string name, int reward)
        {
            Name = name;
            Completed = false;
            this.reward = reward;
        }

        public override int RecordEvent()
        {
            return reward;
        }

        public override string DisplayProgress()
        {
            return $"{Name}: {Completed}";
        }

        public override bool CheckCompletion()
        {
            return false; // It is suppose that Eternal Goals can't be completed in a limited period of time
        }
    }
}