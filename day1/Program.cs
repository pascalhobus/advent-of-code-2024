namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 1:");

            var leftList = new List<int>();
            var rightList = new List<int>();
            using (var reader = new StreamReader(@"input.txt") ) {
                while (!reader.EndOfStream) {
                    var split = reader.ReadLine().Split(@"   ");
                    leftList.Add(Int32.Parse(split[0]));
                    rightList.Add(Int32.Parse(split[1]));
                }
            }

            leftList.Sort();    // improve by insert-srot (binary search algo)
            rightList.Sort();   // improve by insert-srot (binary search algo)

            int totalDistance = 0;
            for (int i = 0, j = leftList.Count - 1; i < leftList.Count; i++, j--) { 
                int left = leftList.ElementAt(i);
                int right = rightList.ElementAt(i);
                int distance = Math.Abs(left - right);
                Console.WriteLine($"Pair L:{left} R:{right}, distance {distance}");
                totalDistance += distance;
            }

            Console.WriteLine (totalDistance);
        }
    }
}
