namespace Dearlership.Models
{
  public class Car
  {
    private string MakeModel;
    private int Price;
    private int Miles;

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }  
  } 
}