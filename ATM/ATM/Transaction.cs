namespace ATM;
public delegate void atmBasket(string name);
internal class Transaction
{
    public event atmBasket OnSMS;
    public event atmBasket OnPrint;
    private long fixedDeposit = 500000;
    public int cardNo { get; set; }
    public int pin { get; set; }
    public long WithdrawalAmt { get; set; }
    public long mobileNo { get; set; }

    public string withdrawal(long withAmt) 
    {
        try
        {
            if (withAmt > fixedDeposit)
            {
                throw new Exception("Insufficient Balance");
            }
            if (OnSMS != null)
            {
                OnSMS($"{WithdrawalAmt}");
            }
            if (OnPrint != null)
            {
                OnPrint($"{WithdrawalAmt}");
            }
            //fixedDeposite -= withAmt;
            return $"{withAmt} amount Withdraw Successfully";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}
