using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class FizzBuzz
    {
        private int _userValue;

        public FizzBuzz (int userValue)
        {
            _userValue = userValue;
        }

        public void PlayTheGame()
        {
            if (_userValue % 3 == 0 && _userValue % 5 == 0)
                Console.WriteLine("FizzBuzz!"); 
            else if (_userValue%5 == 0)
                Console.WriteLine("Buzz!");
            else if (_userValue % 3 == 0)
                Console.WriteLine("Fizz!");
            else
                Console.WriteLine($"To ani Fizz, ani Buzz: {_userValue}");
        }
    }
}
