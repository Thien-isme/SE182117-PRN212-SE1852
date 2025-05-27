int sums(params int[] arr)
{
    int s = 0;
    foreach (int i in arr)
    {
        s += i;
    }
    return s; 
}

int s1 = sums(1);
int s2 = sums(1,2);
int s3 = sums(1,2,3);
Console.WriteLine($"s1 = {s1}; s2 = {s2}; s3 = {s3}");

int? a = null;





















