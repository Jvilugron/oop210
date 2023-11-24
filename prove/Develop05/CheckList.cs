using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
     class CheckList : Goal
    {
        private int rewardPerCompletion;
        private int targetTimes;
        private int bonus;
        private int timesCompleted;

        public CheckList(string name, int rewardPerCompletion, int targetTimes, int bonus)
        {
            Name = name; 
            Completed = false;
            this.rewardPerCompletion = rewardPerCompletion;
            this.targetTimes = targetTimes;
            this.bonus = bonus; 
            timesCompleted = 0;
        }

        public override int RecordEvent()
        {
            timesCompleted++;
            if (timesCompleted == targetTimes)
            {
                Completed = true;
                return rewardPerCompletion * targetTimes + bonus;
            }

            return rewardPerCompletion;
        }

        public override string DisplayProgress()
        {
            return Completed ? $"[X] {Name}: Completed {timesCompleted}/{targetTimes} times":
                               $"[ ] {Name}: Completed {timesCompleted}/{targetTimes} times"; 
        }

        public override bool CheckCompletion()
        {
            return Completed;
        }
    }
}