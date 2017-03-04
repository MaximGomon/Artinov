namespace Singleton
{
    /// <summary>
    /// No thread safe singleton
    /// </summary>
    public class WarningSingletonManaget
    {
        private SingletonObject _object;

        public SingletonObject Instance
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