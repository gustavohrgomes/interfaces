namespace Course.Services
{
    public class PaypalPayment : IOnlinePaymentService
    {
        private const double MonthlyInterest = 0.01;
        private const double FeePercentage = 0.02;

        public double PaymentFee(double amount) => amount * FeePercentage;
        public double Interest(double amount, int months) => amount * MonthlyInterest * months;
    }
}