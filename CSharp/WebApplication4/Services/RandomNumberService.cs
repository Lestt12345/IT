namespace WebApplication4.Services
{
    public class RandomNumberService
    {
        public int Get()
        {
            return new Random().Next(1, 101);
        }
    }
}