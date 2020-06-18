
namespace ExAbstract.Entities
{
    class Individual : Payers
    {
        public double HealthCare { get; set; }

        public Individual(string name, double anualIncome, double healthCare) : base(name, anualIncome)
        {
            HealthCare = healthCare;
        }

        public sealed override double Taxes()
        {
            double tax;

            if (AnualIncome < 20000)
            {
                tax = AnualIncome * 0.15;
            }else
            {
                tax = AnualIncome * 0.25;
            }

            tax -= HealthCare / 2;

            return tax;
        }
    }
}
