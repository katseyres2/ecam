# utils.py
# Math library
# Author: Sébastien Combéfis
# Version: February 8, 2018

import math
from math import sqrt
from scipy import integrate
# import scipy

def fact(n):
	"""Computes the factorial of a natural number.
	
	Pre: -
	Post: Returns the factorial of 'n'.
	Throws: ValueError if n < 0
	"""
	try:
		return math.factorial(n)
	except ValueError:
		return False

def roots(a, b, c):
	"""Computes the roots of the ax^2 + bx + x = 0 polynomial.
	
	Pre: -
	Post: Returns a tuple with zero, one or two elements corresponding
		to the roots of the ax^2 + bx + c polynomial.
	"""

	delta = b**2 - 4 * a * c

	if (delta < 0):
		return ()
	elif (delta == 0):
		x = -b / (2 * a)
		return (x)
	elif (delta > 0):
		x1 = (-b + sqrt(delta)) / (2 * a)
		x2 = (-b - sqrt(delta)) / (2 * a)
		return (x1, x2)

def integral(function, lower:int, upper:int):
	"""Approximates the integral of a fonction between two bounds
	
	Pre: 'function' is a valid Python expression with x as a variable,
		'lower' <= 'upper',
		'function' continuous and integrable between 'lower‘ and 'upper'.
	Post: Returns an approximation of the integral from 'lower' to 'upper'
		of the specified 'function'.

	Hint: You can use the 'integrate' function of the module 'scipy' and
		you'll probably need the 'eval' function to evaluate the function
		to integrate given as a string.
	"""
	
	lower if lower < upper else upper
	upper if upper > lower else lower

	f = lambda x: eval(function)
	return round(integrate.quad(f, lower, upper)[0], 4)

if __name__ == '__main__':
# 	print(fact(5))
	# print(roots(1, 0, 1))
	# print(integral('x ** 2 - 1', -1, 1))
	pass