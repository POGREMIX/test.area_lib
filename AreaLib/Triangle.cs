namespace AreaLib
{
    public class Triangle : Figure
    {
        private readonly int A;
        private readonly int B;
        private readonly int C;

        public Triangle(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0){
                throw new ArgumentException("SIDES OF TRIANGLE CANNOT BE NEGATIVE");
            }

            A = a;
            B = b;
            C = c;
        }

        public override double GetArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public bool IsRight()
        {
            var hypotenuse = Math.Max(Math.Max(A, B), C);
            
            if (A == hypotenuse)
            {
                return Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2);
            } 
            else if (B == hypotenuse)
            {
                return Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C, 2);
            }
            else
            {
                return Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2);
            }
        }
    }
}
