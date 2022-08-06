# test_utils.py
# Author: Sébastien Combéfis
# Version: February 8, 2018

import unittest
import utils
import xmlrunner

class TestUtils(unittest.TestCase):
    def test_fact(self):
        self.assertEqual(utils.fact(5), 120)
        self.assertFalse(utils.fact(-4))
        self.assertEqual(utils.fact(0), 1)
    
    def test_roots(self):
        self.assertEqual(utils.roots(1, 0, 1), ())
        self.assertEqual(utils.roots(1, 2, -15), (3, -5))
        self.assertEqual(utils.roots(1, -14, 49), (7))
        
    
    def test_integrate(self):
        self.assertEqual(utils.integral("2 * x**2 - 4 * x + 2", -2, 4), 36)
        self.assertEqual(utils.integral("2 * x**2 - 4 * x + 2", 2, -4), -84)

if __name__ == '__main__':
    unittest.main(
        testRunner=xmlrunner.XMLTestRunner(output='test-reports'),
        failfast=False, buffer=False, catchbreak=False)