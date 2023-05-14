using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateMachine
{

    /// <summary>
    /// 狀態機 一個StateMachine代表一個有限狀態機
    /// </summary>
    public class StateMachine
    {
        public IReadOnlyDictionary<Guid, State> states = new Dictionary<Guid, State>();
    }
}
