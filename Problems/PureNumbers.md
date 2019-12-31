
You are given a special set of pure numbers.
A pure number has the following properties:
1. It comprises only 4 and 5.
2. It is a palindrome number.
3. The number of digits in a pure number is even.

For example, 4444,5445,44 are the pure numbers while 12,444,4545 are not. You have to generate a list of
pure numbers in an ascending order. So, purenumber[1] < purenumber[2].
The 􀃒rst few elements in the list are as follows: 44,55,4444,....
You will be given an integer and you have to 􀃒nd pure number from the generated list.


static public void Main()
{
 String line;
line = Console.ReadLine();
 int T = Convert.ToInt32(line);

for(int t_i=0; t_i<T; t_i++)
 {
 line = Console.ReadLine();
 int N = Convert.ToInt32(line);

 String out_ = Solve(N);
 Console.WriteLine(out_);

 }
 }
