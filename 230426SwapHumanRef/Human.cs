namespace SwapHumanRef
{
    public class Human
    {
        private Face mFace = new Face();
        
        public void SetFace(Face face)
        {
            mFace = face;
        }

        public Face GetFace()
        {
            return mFace;
        }
    }
}
