namespace TT_hoby.AlgorithmOperations
{
  public class AlgorithmOperations
  {
    public int CountFibonacciNumbers(int serialNumber)
    {
      if (serialNumber >= 2) return CountFibonacciNumbers(serialNumber - 1) + CountFibonacciNumbers(serialNumber - 2);
      return serialNumber;
    }

    public double CountNumberExponentiation(double number, int extent)
    {
      if (extent == 0) return 1;

      if (extent > 0) return number * CountNumberExponentiation(number, extent - 1);

      return 1 / (number * CountNumberExponentiation(number, -extent - 1));
    }
  }
}