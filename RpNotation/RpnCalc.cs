using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace RpNotation
{
  class RpnCalc
  {
    Stack<int> stk = new Stack<int>();
    public string RpnCal(string value)
    {
      
      string[] arr = value.Split();
      foreach (string token in arr)
      {

        int abc, number = 0;

        try
        {
          if (Int32.TryParse(token, out abc))
          {
            if(abc < int.MinValue || abc > int.MaxValue)
            {
              string message = OutOfRangeException();
              return message;
            }
            stk.Push(abc);

          }
          else
          {
            switch (token)
            {
              case "+":
                stk.Push(stk.Pop() + stk.Pop());
                break;

              case "-":
                number = stk.Pop();
                stk.Push(stk.Pop() - number);
                break;

              case "*":
                stk.Push(stk.Pop() * stk.Pop());
                break;

              case "/":
                number = stk.Pop();
                stk.Push(stk.Pop() / number);
                break;

            }
          }
        }
        catch (System.InvalidOperationException)
        {
          return "Invalid Expression";
        }  
      }
      return stk.Pop().ToString();
    }

    public string OutOfRangeException()
    {
      return "Out of range exception";
    }
  }
}
