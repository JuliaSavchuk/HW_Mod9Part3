namespace HW_Mod9Part3
{
    public static class Task4
    {
        public static bool AreBracketsValid(this string str)
        {
            var stack = new Stack<char>();
            foreach (var ch in str)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if (stack.Count == 0) return false;
                    var openBracket = stack.Pop();
                    if (!IsMatchingPair(openBracket, ch)) return false;
                }
            }
            return stack.Count == 0;
        }

        private static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') || (open == '{' && close == '}') || (open == '[' && close == ']');
        }
    }
}
