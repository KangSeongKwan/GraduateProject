using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculator : MonoBehaviour
{
    public int cal(int sum, List<string> test)
    {
        int a;
        string b;
        int summ = sum;
        for(int i =0; i<test.Count; i++)
        {
            b = test[i].Substring(0, 1);
            a = int.Parse(test[i].Substring(1, 1));

            switch (b)
            {
                case "*":
                    summ *= a;
                    break;
                case "/":
                    summ /= a;
                    break;
                case "+":
                    summ += a;
                    break;
                case "-":
                    summ -= a;
                    break;
            }
                
        }
        return summ;
    }
    public int Cal1(int sum, string abc)
    {
        int a;
        string b;
        b = abc.Substring(0, 1);
        a = int.Parse(abc.Substring(1, 1));

        switch (b)
        {
            case "*":
                sum *= a;
                break;
            case "/":
                sum /= a;
                break;
            case "+":
                sum += a;
                break;
            case "-":
                sum -= a;
                break;
        }
        return sum;
    }
}
