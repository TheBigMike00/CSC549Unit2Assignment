using System;

namespace Unit2Assignment
{
    class Driver
    {
        #region Exercise 1.10
        /*
        Procedure:
        (define (A x y)
            (cond ((= y 0) 0)
                ((= x 0) (* 2 y))
                ((= y 1) 2)
                (else (A (- x 1) (A x (- y 1))))))

         What are the values of the following expressions?
        (A 1 10) = ... 
        (A 0 (A 1 9))
        (A 0 (A 0 (A 1 8)))
        (A 0 (A 0 (A 0 (A 1 7))))
        (A 0 (A 0 (A 0 (A 0 (A 1 6)))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 5))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 4)))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 3))))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 2)))))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 1))))))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 2)))))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 4))))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 8)))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 16))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 32)))))
        (A 0 (A 0 (A 0 (A 0 64))))
        (A 0 (A 0 (A 0 128)))
        (A 0 (A 0 256))
        (A 0 512)
        1024



        (A 2 4) = ...
        (A 1 (A 2 3))
        (A 1 (A 1 (A 2 2)))
        (A 1 (A 1 (A 1 (A 2 1))))
        (A 1 (A 1 (A 1 2)))
        (A 1 (A 1 (A 0 (A 1 1))))
        (A 1 (A 1 (A 0 2)))
        (A 1 (A 1 4))
        (A 1 (A 0 (A 1 3)))
        (A 1 (A 0 (A 0 (A 1 2))))
        (A 1 (A 0 (A 0 (A 0 (A 1 1)))))
        (A 1 (A 0 (A 0 (A 0 2))))
        (A 1 (A 0 (A 0 4)))
        (A 1 (A 0 8))
        (A 1 16)
        (A 0 (A 1 15))
        (A 0 (A 0 (A 1 14)))
        (A 0 (A 0 (A 0 (A 1 13))))
        (A 0 (A 0 (A 0 (A 0 (A 1 12)))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 11))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 10)))))))
                                        -> reference work above for (A 1 10)
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 1024))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 2048)))))
        (A 0 (A 0 (A 0 (A 0 4096))))
        (A 0 (A 0 (A 0 8192)))
        (A 0 (A 0 16384))
        (A 0 32768)
        65536



        (A 3 3) = ...
        (A 2 (A 3 2))
        (A 2 (A 2 (A 3 1)))
        (A 2 (A 2 2))
        (A 2 (A 1 (A 2 1)))
        (A 2 (A 1 2))
        (A 2 (A 0 (A 1 1)))
        (A 2 (A 0 2))
        (A 2 4)
        (A 1 (A 2 3))
        (A 1 (A 1 (A 2 2)))
        (A 1 (A 1 (A 1 (A 2 1))))
        (A 1 (A 1 (A 1 2)))
        (A 1 (A 1 (A 0 (A 1 1))))
        (A 1 (A 1 (A 0 2)))
        (A 1 (A 1 4))
        (A 1 (A 0 (A 1 3)))
        (A 1 (A 0 (A 0 (A 1 2))))
        (A 1 (A 0 (A 0 (A 0 (A 1 1)))))
        (A 1 (A 0 (A 0 (A 0 2))))
        (A 1 (A 0 (A 0 4)))
        (A 1 (A 0 8))
        (A 1 16)
        -> reference work above for (A 1 16)
        (A 1 16)
        (A 0 (A 1 15))
        (A 0 (A 0 (A 1 14)))
        (A 0 (A 0 (A 0 (A 1 13))))
        (A 0 (A 0 (A 0 (A 0 (A 1 12)))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 11))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 (A 1 10)))))))
                                        -> reference work above for (A 1 10)
        (A 0 (A 0 (A 0 (A 0 (A 0 (A 0 1024))))))
        (A 0 (A 0 (A 0 (A 0 (A 0 2048)))))
        (A 0 (A 0 (A 0 (A 0 4096))))
        (A 0 (A 0 (A 0 8192)))
        (A 0 (A 0 16384))
        (A 0 32768)
        65536
        

        Consider the following procedures, where A is the procedure defined above:
        (define (f n) (A 0 n))
        -> 2n (immediately results in (* 2 y) or 0 if n = 0)

        (define (g n) (A 1 n))
        -> 2^n, 0 if n = 0

        (define (h n) (A 2 n))
        -> (2^(2^(2^n ... n times)), 0 if n = 0

        (define (k n) (* 5 n n))
        -> 5n^2

         */


        #endregion


        #region Exercise 1.11
        public static int KindaLikeFibRecursive(int n)
        {
            if (n < 3)
                return n;
            else
            {
                return KindaLikeFibRecursive(n - 1) 
                    + (2 * KindaLikeFibRecursive(n - 2)) 
                        + (3 * KindaLikeFibRecursive(n - 3));
            }
        }

        public static int KindaLikeFibIterative(int n)
        {
            if (n < 3)
                return n;
            return KindaLikeFibIterative_iter(2, 1, 0, n-2);
        }

        public static int KindaLikeFibIterative_iter(int val1, int val2, int val3, int count)
        {
            if (count == 0)
                return val1;
            else
            {
                return KindaLikeFibIterative_iter((val1 + (2 * val2) + (3 * val3)), val1, val2, count-1);
            }
        }



        #endregion


        #region Exercise 1.12
        public static int GetPascalValue(int row, int column) //Assumes valid row/col
        {
            if (row == 1)
                return 1;
            if (column == 1 || column == row)
                return 1;
            else
                return GetPascalValue(row - 1, column - 1) + GetPascalValue(row - 1, column);
        }

        #endregion


        #region Exercise 1.23
        public static int GetSmallestDivisor(int num)
        {
            //long millisecondsBefore = DateTime.Now.Millisecond;
            int result = FindDivisor(num, 2);
            //long millisecondsAfter = DateTime.Now.Millisecond;
            //long timeDifference = millisecondsAfter - millisecondsBefore; //Using Next = 303, Without Next = 695 (input = 1034233)
            return result;
        }

        public static int FindDivisor(int num, int test)
        {
            if ((test * test) > num)
                return num;
            if (num % test == 0)
                return test;
            return FindDivisor(num, Next(test));
        }

        public static int Next(int n)
        {
            if (n == 2)
                return 3;
            return n + 2;
        }
        #endregion



        static void Main(string[] args)
        {
            //Excercise 1.11
            Console.WriteLine("KindaFib Recusive Method: " + KindaLikeFibRecursive(5) + "\n");
            Console.WriteLine("KindaFib Iterative Method: " + KindaLikeFibIterative(5) + "\n\n");

            //Exercise 1.12
            Console.WriteLine("Get Value of Pascal Triange: " + GetPascalValue(5,3) + "\n\n");

            //Exercise 1.23
            Console.WriteLine("Smallest Divisor: " + GetSmallestDivisor(1034233) + "\n\n");
        }
    }
}
