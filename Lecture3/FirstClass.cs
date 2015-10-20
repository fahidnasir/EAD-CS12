using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3
{
    class FirstClass : ParentClass
    {
        private const string CONSTANT = "this is UPPERCASE naming";
        private string variableName = "this is camelCase naming";

        private string _variable;
        public string VariableName
        {
            get
            {
                _variable = "this is PascalCase naming";
                return _variable;
            }
            set
            {
                _variable = value;
            }
        }

        public int PropertyWithNoLogic{get; set;}

        static void Main(string[] args)
        {
            string localVariable = "this is accessable only in this method.";

            #region Loops
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            foreach (var item in new string[10])
            {

            }
            while (true)
            {
                break;
            }
            do { break; } while (true);
            #endregion

            #region Conditions
            if (10 > 15) { }

            int x = 10;
            switch (x)
            {
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;
            }

            string name = x > 12 ? "Ali" : "Rizwan";
            #endregion

            #region Try-Catch
            try { }
            catch (Exception e) { Console.WriteLine(e.Message); }
            finally { }
            #endregion

            #region Using
            //using (IDisposable Object)
            //{
            //}
            #endregion

            Console.ReadKey();
        }
    }
    class ParentClass{

    }
}
