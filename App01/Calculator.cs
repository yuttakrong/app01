using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App01
{
    public class Calculator
    {

      public string add(string value1 ,string value2) {

      //throw new NotImplementedException();

      /*
      if (string.IsNullOrEmpty(value1)) value1 = "0";
      if (string.IsNullOrEmpty(value2)) value2 = "0";
      int v1 = Convert.ToInt32(value1);
      int v2 = Convert.ToInt32(value2);
      return (v1 + v2).ToString();
      */

      //if (string.IsNullOrEmpty(value1)) value1 = "0";
      //if (string.IsNullOrEmpty(value2)) value2 = "0";

      //char[] tempValue1 = value1.ToCharArray();
      //char[] tempValue2 = value2.ToCharArray();
      //int tempPlusValue = 0;
      //for(int i= tempValue1.Length;i> tempValue1.Length - 1; i--) 
      //{
      //}
      

      if (string.IsNullOrEmpty(value1)) value1 = "0";
      if (string.IsNullOrEmpty(value2)) value2 = "0";

      if(HasNonDigits(value1)) {
        throw new ArgumentException("Value can't contains non digit charactors",
          nameof(value1));
      }
      if (HasNonDigits(value2)) {
        throw new ArgumentException("Value can't contains non digit charactors",
          nameof(value2));
      }

      int sign1 = value1[0] == '-' ? -1 : 1;
      int sign2 = value2[0] == '-' ? -1 : 1;

      char ch1 = value1[value1.Length - 1];
      char ch2 = value2[value2.Length - 1];

      int v1 = (int)(ch1 - '0') * sign1;
      int v2 = (int)(ch2 - '0') * sign2;


      return (v1 + v2).ToString();

    }

    private bool HasNonDigits(string value) {

      foreach(char c in value) {
        if (!char.IsDigit(c) && c != '-') {
          return true;
        }
      }

      return false;//throw new NotImplementedException();      

    }
  }
}
