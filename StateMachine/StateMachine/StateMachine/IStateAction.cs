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
    public interface IStateAction
    {
        /// <summary>
        /// 
        /// </summary>
        void Action(BlackBoard blackBoard);
    }
}
