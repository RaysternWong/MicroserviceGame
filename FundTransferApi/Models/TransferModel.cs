namespace FundTransferApi.Models
{
    public class TransferModel
    {
        public string Token { get; set; }
        public double Amount { get; set; }
    }

    public class TopUpModel : TransferModel
    { }

    public class WithdrawModel : TransferModel
    { }
}
