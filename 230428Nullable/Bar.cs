namespace Nullable
{
    public struct Bar
    {
        #region CONSTRUCTOR
        public Bar(int number)
        {
            Number = number;
        }
        #endregion

        #region MEMBER VARIABLE, PROPERTY
        public int Number { get; private set; }
        #endregion
    }
}
