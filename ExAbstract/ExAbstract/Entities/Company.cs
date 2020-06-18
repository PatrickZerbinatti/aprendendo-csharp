
namespace ExAbstract.Entities
{
    class Company : Payers
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public sealed override double Taxes()
        {
            double tax;
            if (NumberOfEmployees <= 10 )
            {
                tax = AnualIncome * 0.16;
            }
            else
            {
                tax = AnualIncome * 0.14;
            }

            return tax;
        }
    }
}
