namespace EuclideanAlgorithm
{
	/// <summary>
	/// The class implements two version of the Euclidean algorithm, one
	/// iterative and one recursive, which is used to calculate the Greatest
	/// Common Divisor (GCD) of two numbers.
	/// </summary>
	public static class EuclideanAlgorithm
	{
		/// <summary>
		/// Calculates the Greatest Common Divisor of the two specified numbers,
		/// in an iterative way.
		/// </summary>
		/// <param name="n">The first number to calculate the GCD</param>
		/// <param name="m">The second number to calculate the GCD</param>
		/// <returns>The GCD</returns>
		public static int IterativeGCD(int n, int m)
		{
			while (m > 0)
			{
				int temp = n;
				n = m;
				m = temp % m;
			}
			return n;
		}

		/// <summary>
		/// Calculates the Greatest Common Divisor of the two specified numbers,
		/// in a recursive way.
		/// </summary>
		/// <param name="n">The first number to calculate the GCD</param>
		/// <param name="m">The second number to calculate the GCD</param>
		/// <returns>The GCD</returns>
		public static int RecursiveGCD(int n, int m)
		{
			if (m == 0) return n;
			return RecursiveGCD(m, n % m);
		}
	}
}
