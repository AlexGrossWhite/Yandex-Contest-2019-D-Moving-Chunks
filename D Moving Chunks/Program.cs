int[] ints = Console.ReadLine().Split(' ').Select(o => Int32.Parse(o)).ToArray();
List<int> result = new List<int>();
int[] chunks = Console.ReadLine().Split(' ').Select(o => Int32.Parse(o)).ToArray();
for (int i = 0; i < ints[2]; i++)
{
    int[] request = Console.ReadLine().Split(' ').Select(o => Int32.Parse(o)).ToArray();
    for (int j = request[2] - 1; j <= request[3] - 1; j++)
    {
        if (chunks[j] != request[0])
        {
            result.Add(0);
            break;
        }
    }
    if (result.Count < i + 1) result.Add(1);
    if (result[^1] == 1)
    {
        for (int j =  request[2] - 1; j <= request[3] - 1; j++)
        {
            chunks[j] = request[1];
        }
    }
}
foreach (int i in result)
{
    Console.WriteLine(i);
}