namespace SUVATNuGet;

public class SUVATEquations
{
  public double DisplacementUTV(double u, double t, double v)
  {
    var s = 1/2 * (u + v) * t;
    return s;
  }

  public double DisplacementUTA(double u, double t, double a)
  {
    var s = u * t + 1/2 * a * Math.Pow(t, 2);
    return s;
  }

  public double DisplacementUVA(double u, double v, double a)
  {
    var s = (Math.Pow(v, 2) - Math.Pow(u, 2)) / (2 * a);
    return s;
  }

  public double InitialVelocityUTA(double u, double t, double a)
  {
    var v = u + t * a;
    return v;
  }

  public double InitialVelocityUAS(double u, double a, double s)
  {
    var result = Math.Pow(u, 2) + 2 * a * s;
    var v = Math.Sqrt(result);
    return v;
  }

  public double InitialVelocityUTS(double u, double t, double s)
  {
    var v = 2 * (s / t) - u; 
    return v;
  }

  public double InitialVelocityTAS(double t, double a, double s)
  {
    var v = (s + 1 / 2 * a * Math.Pow(t, 2)) / t;
    return v;
  }

  public double FinalVelocityVAT(double v, double a, double t)
  {
    var u = v - a * t;
    return u;
  }

  public double FinalVelocityVST(double v, double s, double t)
  {
    var u = 2 * (s / t) - v;
    return u;
  }

  public double FinalVelocityVAS(double v, double a, double s)
  {
    var result = Math.Pow(v, 2) - 2 * a * s;
    var u = Math.Sqrt(result);
    return u;
  }

  public double FinalVelocitySAT(double s, double a, double t)
  {
    var u = (s - 1 / 2 * a * Math.Pow(t, 2)) / t;
    return u;
  }

  public double AccelerationVUT(double v, double u, double t)
  {
    var a = (v - u) / t;
    return a;
  }

  public double AccelerationVUS(double v, double u, double s)
  {
    var a = (Math.Pow(v, 2) - Math.Pow(u, 2)) / (2 * s);
    return a;
  }

  public double AccelerationSUT(double s, double u, double t)
  {
    var a = 2 * (s - u * t) / Math.Pow(t, 2);
    return a;
  }

  public double AccelerationSVT(double s, double v, double t)
  {
    var a = 2 * (s - v * t) / Math.Pow(t, 2);
    return a;
  }
}

