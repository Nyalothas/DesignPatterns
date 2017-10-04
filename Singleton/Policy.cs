namespace Singleton
{
    public class Policy
    {
        private static readonly Policy _instance = new Policy();
        public static Policy Instance {
            get
            {
                return _instance;
            }
        }

        public Policy()
        {

        }

        public int Id { get; set; }
        public string Insured { get; set; } = "Tim Bob";
        public string GetInsuredName() => Insured;
    }

    // Alternative implementation
    /*
    public class Policy
    {
        private static Policy _instance;
        public static Policy Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Policy();
                }
                return _instance;
            }
        }

        public Policy()
        {

        }
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "Tim Bob";

        public string GetInsuredName() => Insured;
    }
    */
}
