using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
static void Main(String[] args) {
int n = int.Parse(Console.ReadLine());
int[] clouds = Array.ConvertAll(Console.ReadLine() .Split(' '), e => int.Parse(e));
int jumps = 0;
for (int i = 0; i + 1 < clouds.Length; )
{
if (clouds[i + 1] == 1 || (i+2 < clouds.Length && clouds[i+2] ==0))
{
jumps++;
i += 2;
}
else
{
jumps++;
i++;
}
}
Console.WriteLine(jumps);
}
}