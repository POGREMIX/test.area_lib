namespace AreaLib
{
    public abstract class Figure
    {
        public abstract double GetArea();

        public static double GetArea(dynamic obj)
        {
            if (obj is Circle circle)
            {
                return circle.GetArea();
            }
            else if(obj is Triangle triangle)
            {
                return triangle.GetArea();
            } else
            {
                throw new ArgumentException("UNKNOWN FIGURE TYPE");
            }
        }
    }
}
