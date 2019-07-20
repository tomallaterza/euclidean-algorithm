/**
 * The class implements two version of the Euclidean algorithm, one iterative
 * and one recursive, which is used to calculate the Greatest Common Divisor
 * (GCD) of two numbers.
 * 
 * @author Tommaso Tamagnini
 * @version 1.0
 */
public class EuclideanAlgorithm {
	
	/**
	 * Calculates the Greatest Common Divisor of the two specified numbers, in an
	 * iterative way.
	 * 
	 * @param n The first number to calculate the GCD
	 * @param m The second number to calculate the GCD
	 * @return The GCD
	 */
	public static int iterativeGCD(int n, int m) {
		while (m > 0) {
			int temp = n;
			n = m;
			m = temp % m;
		}
		return n;
	}

	/**
	 * Calculates the Greatest Common Divisor of the two specified numbers, in a
	 * recursive way.
	 * 
	 * @param n The first number to calculate the GCD
	 * @param m The second number to calculate the GCD
	 * @return The GCD
	 */
	public static int recursiveGCD(int n, int m) {
		if (m == 0) return n;
		else return recursiveGCD(m, n % m);
	}
}
