#!/usr/bin/python
# -*- coding: utf-8 -*-


"""
There are two implementations of the Euclidean algorithm, one iterative and one 
recursive, which is used to calculate the Greatest Common Divisor (GCD) of two 
numbers.
"""


__author__ = "Tommaso Tamagnini"
__copyright__ = "Copyright 2019, Tommaso Tamagnini"
__license__ = "MIT License"
__version__ = "1.0"


def iterative_gcd(n, m):
    """
    Calculates the Greatest Common Divisor of the two specified numbers, in an 
    iterative way.

    :param n: The first number to calculate the GCD
    :type n: int
    :param m: The second number to calculate the GCD
    :type m: int
    :returns: The GCD
    :rtype: int
    """

    while m > 0: (n, m) = (m, n % m)
    return n


def recursive_gcd(n, m):
    """
    Calculates the Greatest Common Divisor of the two specified numbers, in a 
    recursive way.

    :param n: The first number to calculate the GCD
    :type n: int
    :param m: The second number to calculate the GCD
    :type m: int
    :returns: The GCD
    :rtype: int
    """

    if m == 0: return n
    else: return recursive_gcd(m, n % m)
