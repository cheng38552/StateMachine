using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{

    /// <summary>
    /// 
    /// </summary>
    public sealed class State
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid guid { get; private set; };
        /// <summary>
        /// 
        /// </summary>
        public List<IStateTransition> transitions;
        /// <summary>
        /// 
        /// </summary>
        public IStateAction action;

        public State()
        {
            guid = Guid.
        }

    }
}
