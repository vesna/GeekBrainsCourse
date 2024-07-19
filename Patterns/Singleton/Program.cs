class Program
{
    public class Singleton
    {
       // private static Singleton instance;
      //  private static readonly object loclObj = new object();

        private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());

        private Singleton() { }

        public static Singleton Instance = lazyInstance.Value;

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        if(instance == null)
        //        {
        //            lock(loclObj)
        //            {
        //                if (instance == null)
        //                {
        //                    instance = new Singleton();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}
        public void DoSomeWork() => Console.WriteLine("Work");
    }
    static void Main(string[] args)
    {
        Singleton.Instance.DoSomeWork();
    }
}