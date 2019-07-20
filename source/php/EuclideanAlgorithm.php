<?php
/**
 * There are two implementations of the Euclidean algorithm, one iterative
 * and one recursive, which is used to calculate the Greatest Common Divisor
 * (GCD) of two numbers.
 * 
 * @author Tommaso Tamagnini
 * @version 1.0
 */

/**
 * Calculates the Greatest Common Divisor of the two specified numbers, in an
 * iterative way.
 * 
 * @param int $n The first number to calculate the GCD
 * @param int $m The second number to calculate the GCD
 * @return int The GCD
 */
function iterativeGCD($n, $m) {
    while ($m > 0) {
        $temp = $n;
        $n = $m;
        $m = $temp % $m;
    }
    return $n;
}

/**
 * Calculates the Greatest Common Divisor of the two specified numbers, in a
 * recursive way.
 * 
 * @param int $n The first number to calculate the GCD
 * @param int $m The second number to calculate the GCD
 * @return int The GCD
 */
function recursiveGCD($n, $m) {
    if ($m == 0) return $n;
    else return recursiveGCD($m, $n % $m);
}
?>
