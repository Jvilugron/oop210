using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    class SimpleGoal : Goal
    {
        private int reward;

        public SimpleGoal(string name, int reward)
        {
            Name = name;
            Completed = false;
            this.reward = reward;
        }

        public override string DisplayProgress()
        {
            return Completed ? $"[X] {Name}" : $"[ ] {Name}";
        }

        public override bool CheckCompletion()
        {
            return Completed; 
        }
    }
}