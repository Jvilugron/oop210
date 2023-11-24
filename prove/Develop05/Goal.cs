using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop05
{
    abstract class Goal
    {
        public string Name { get; protected set; }
        public bool Completed { get; protected set; }

        public abstract int RecordEvent();
        public abstract string DisplayProgress();
        public abstract bool CheckCompletion();
    }
}