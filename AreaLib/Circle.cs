namespace AreaLib
{
    public class Circle: Figure
    {
        private readonly float radius;

        public Circle(float radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("RADIUS LESS THEN 0");
            }
            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
