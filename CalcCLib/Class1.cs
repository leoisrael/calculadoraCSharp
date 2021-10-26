using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcCLib
{
    public class FullcalcObject : CalcObject
    {
        public List<int> nums;

        public FullcalcObject(List<int> numsParamsCalc)
        {
            nums = new List<int>();
            NumsSet(numsParamsCalc);
        }

        public FullcalcObject(int[] numsParamsCalc)
        {
            nums = new List<int>();
            NumsSet(numsParamsCalc);
        }

        public FullcalcObject(string[] numsParamsCalc)
        {
            nums = new List<int>();
            NumsSet(numsParamsCalc);
        }

        public List<int> NumsGet()
        {
            List<int> nums2 = new List<int>();
            nums2.AddRange(nums);
            return nums2;
        }

        public void NumsSet(List<int> numListCalc)
        {
            if (numListCalc == null)
            {
                throw new ArgumentNullException("Lista com valor nulo");
            }
            nums.Clear();
            nums.AddRange(numListCalc);
        }

        public void NumsSet(int[] numArrayCalc)
        {
            nums.Clear();
            nums.AddRange(numArrayCalc);
        }

        public void NumsSet(string[] arrayNum)
        {
            nums.Clear();
            for (int i = 0; i < arrayNum.Length; i++)
            {
                int numero = 0;
                if (int.TryParse(arrayNum[i], out numero))
                {
                    nums.Add(numero);
                }
            }
        }

        public int sub()
        {
            return sub(nums);
        }

        public int soma()
        {
            return soma(nums);
        }

        public float div()
        {
            return div(nums);
        }

        public int fatora()
        {
            return fatora(nums[0]);
        }
    }

    public class AutoCalcObject : FullcalcObject
    {
        private const string CALC_DIV = "/";
        private const string CALC_SUM = "+";
        private const string CALC_FAT = "!";
        private const string CALC_SUB = "-";

        private string calc_function = "";
        public float resultado = 0;

        public AutoCalcObject(string[] numsParamsCalc) : base(numsParamsCalc)
        {
            calc_function = numsParamsCalc[0];
            if (calc_function == CALC_DIV)
            {
                resultado = (base.div());
            }
            if (calc_function == CALC_SUM)
            {
                resultado = (base.soma());
            }
            if (calc_function == CALC_FAT)
            {
                resultado = (base.fatora());
            }
            if (calc_function == CALC_SUB)
            {
                resultado = (base.sub());
            }
        }
        public float Print()
        {
            float print = resultado;
            return print;
        }
    }

    public class CalcObject
    {
        //soma
        public int soma(List<int> num)
        {
            int resultado = 0;
            for (int i = 0; i < num.Count; i++)
            {
                int value = num[i];
                resultado += value;
            }
            return resultado;
        }

        //fatoracao
        public int fatora(int nfatora)
        {
            if (nfatora == 1)
            {
                return 1;
            }
            return nfatora * fatora(nfatora - 1);
        }

        //subtracao
        public int sub(List<int> num)
        {
            int resultado = (num[0] - num[1]);
            return resultado;
        }

        //divisao
        public float div(List<int> num)
        {
            int resultado = 0;
            try
            {
                resultado = (num[0] / num[1]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" Não é possivel dividir por zero");
            }
            return resultado;
        }

    }
}
