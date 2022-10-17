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
}
