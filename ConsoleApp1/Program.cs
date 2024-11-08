
string s = "A man, a plan, a canal: Panama";

s = s.ToLower();
s = String.Concat(s.Where(char.IsLetterOrDigit));
char[] chars= s.ToCharArray();
Array.Reverse(chars);
string s_temp = new string(chars);

Console.WriteLine(s== s_temp);