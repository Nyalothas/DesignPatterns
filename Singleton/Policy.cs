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

        public int Id { get; set; }
        public string Insured { get; set; } = "Tim Bob";
        public string GetInsuredName() => Insured;
    }
}
