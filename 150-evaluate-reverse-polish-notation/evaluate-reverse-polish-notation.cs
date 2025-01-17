public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<string> stack = new Stack<string>();

        foreach(var token in tokens)
        {
            if(token=="+" || token=="-" || token=="*" || token=="/"){
                int number2 = int.Parse(stack.Pop());
                int number1 = int.Parse(stack.Pop());

                int number = 0;

                switch(token){
                    case "+": number= number1+number2; break;
                    case "-": number= number1-number2; break;
                    case "*": number= number1*number2; break;
                    case "/": number= number1/number2; break;
                }

                stack.Push(number.ToString());
            }
            else {
                stack.Push(token);
            }
        }

        return int.Parse(stack.Pop());
    }
}