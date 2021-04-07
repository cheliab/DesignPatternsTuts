namespace SingletoneMultiTheadExample
{
    // Версия одиночки для нескольких потоков
    public class SingletoneThreadSafe
    {
        private SingletoneThreadSafe() { }

        private static SingletoneThreadSafe _instance;

        // объект-блокировка для синхронизации потоков
        private static readonly object _lock = new object();
        
        public static SingletoneThreadSafe GetInstance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletoneThreadSafe();
                        _instance.Value = value;
                    }
                }
            }

            return _instance;
        }
        
        public string Value { get; set; }
    }
}