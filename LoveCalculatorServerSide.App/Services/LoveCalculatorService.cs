using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoveCalculatorLogic;

namespace LoveCalculatorServerSide.App.Services
{
    public class LoveCalculatorService
    {
        public async Task<bool> CalculateLove(string first, string second)
        {
            var loveCalculator = new LoveCalculator();
            return loveCalculator.CalculateLove(first, second);
        }
    }
}
