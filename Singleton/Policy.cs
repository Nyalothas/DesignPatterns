namespace Singleton
{
    public class Policy
    {
        public static Policy Instance { get { return new Policy(); } }

        public int Id { get; set; }
        public string Insured { get; set; } = "Tim Bob";
        public string GetInsuredName() => Insured;
    }
}
