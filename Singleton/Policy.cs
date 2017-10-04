namespace Singleton
{
    class Policy
    {
        public int Id { get; set; }
        public string Insured { get; set; } = "Tim Bob";
        public string GetInsuredName() => Insured;
    }
}
