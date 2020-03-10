namespace Parcels.Solutions.Models
{
  public class Parcel
  {
    public int Width { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }
    public double Cost { get; set; }


    public Parcel(int width, int height, int length, int weight)
    {
      Width = width;
      Height = height;
      Length = length;
      Weight = weight;
    }
    public Parcel(int width, int height, int length, int weight, int volume, double cost)
     : this(width, height, length, weight)
    {
      Volume = volume;
      Cost = cost;
    }

    public int GetVolume()
    {
      int volume = Width * Length * Height;
      return volume;
    }

    public double GetCost()
    {
      double cost = (Volume + Weight) / 2;
      return cost;
    }

  }
}