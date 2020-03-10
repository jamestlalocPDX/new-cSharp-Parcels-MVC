using System.Collections.Generic;

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
    private static List<Parcel> _currentParcel = new List<Parcel>();

    public Parcel(int width, int height, int length, int weight)
    {
      Width = width;
      Height = height;
      Length = length;
      Weight = weight;
      _currentParcel.Add(this);
    }
    public Parcel(int width, int height, int length, int weight, int volume, double cost)
     : this(width, height, length, weight)
    {
      Volume = volume;
      Cost = cost;
      _currentParcel.Add(this);
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

    public static List<Parcel> ShowParcel()
    {
      return _currentParcel;
    }

    public static void ClearParcel()
    {
      _currentParcel.Clear();
    }

  }
}