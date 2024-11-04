byte[] ids = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
string[] names = { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hannah", "Isaac" };
double[] scores = { 3d, 7.87d, 9.001d, 11d, 13d, 8d, 9d, 9.2d, 8.86d };
for (int i = 0; i < 9; i++)
{
    if (scores[i] == 9)
    {
        scores[i] += 1;
    }
    scores[i] = Math.Ceiling(scores[i]);
    if (scores[i] >= 10)
    {
        Console.WriteLine("Student ID " + ids[i] + ": " + names[i] + " has passed by score {0}", scores[i]);
    }
    else
    {
        Console.WriteLine("Student ID " + ids[i] + ": " + names[i] + " has failed by score {0}", scores[i]);
    }
}