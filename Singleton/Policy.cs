namespace Singleton
{
    public class Policy
    {
        private static Policy _instance;
        public static Policy Instance {
            get
            {
                if(_instance == null)
                 _instance = new Policy();

                return _instance;
            }
        }

        public int Id { get; set; }
        public string Insured { get; set; } = "Tim Bob";
        public string GetInsuredName() => Insured;
    }
}
