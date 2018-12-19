using System.Threading.Tasks;
using LoveCalculatorLogic;

namespace LoveCalculatorClientSide.Services
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
