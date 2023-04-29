namespace Nullable
{
    public class Foo
    {
        #region CONSTRUCTOR
        /// <summary>
        /// Constructor of Foo
        /// </summary>
        /// <param name="number"></param>
        public Foo(int number)
        {
            Number = number;
        }
        #endregion


        #region MEMBER VARIABLE, PROPERTY
        public int Number { get; private set; }
        #endregion

        #region MEMBER FUNCTION
        public void Increment()
        {
            Number++;
        }

        public void Increment(int increment)
        {
            Number += increment;
        }
        #endregion
    }
}
