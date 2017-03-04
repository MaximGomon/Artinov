namespace Singleton
{
    /// <summary>
    /// Thread safe singleton
    /// </summary>
    public class SingletonManager
    {
        private static SingletonObject _object;

        public static SingletonObject Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new SingletonObject();
                }
                return _object;
            }
        }
    }
}