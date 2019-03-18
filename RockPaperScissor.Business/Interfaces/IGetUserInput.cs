namespace RockPaperScissor.Business.Interfaces
{
    /// <summary>
    /// Get user result
    /// </summary>
    public interface IGetUserInput
    {
        /// <summary>
        /// Show the final result
        /// </summary>
        /// <param name="flagNum"></param>
        /// <returns></returns>
        string ShowResult(int flagNum);

        /// <summary>
        /// Math user insput selection with computer.
        /// </summary>
        void MatchSelection();

        /// <summary>
        /// Method return final winner result.
        /// </summary>
        string DisplayResult();
    }
}
