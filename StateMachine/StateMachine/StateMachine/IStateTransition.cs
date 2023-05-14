

namespace StateMachine
{

    /// <summary>
    /// 
    /// </summary>
    public interface IStateTransition
    {
        /// <summary>
        /// 條件
        /// </summary>
        bool Condition(BlackBoard blackBoard);
    }
}
