using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fit;
using fit.Fixtures;
namespace SqaAssignment
{
    public class CalculatePremium
    {
        public CalculatePremium() { }

        public float CalcPremium(int age, string gender)
        {
            float premium;

            if (gender == "female")
	            if ((age >= 18) && (age <= 30))
                            premium = 5.0F;
                        else
                    if (age >= 31)
                            premium = 2.50F;
                        else
                            premium = 0.0F;
         else
	        if (gender == "male")
	            if ((age >= 18) && (age <= 35))
                        premium = 6.0F;
                    else
                   if (age >= 36)
                        premium = 5.0F;
                    else
                        premium = 0.0F;
         else
		        premium = 0.0F;

                if (age >= 50)
                    premium = premium * 0.15F;
                return premium;
        }
        public class CalculatePremiumTest : ColumnFixture
        {
            public string gender;
            public int age;
            public float premium;

            public CalculatePremium cal = new CalculatePremium();
            
            public float CalcPremium()
            {
                return cal.CalcPremium(age, gender);
            }

        }

    }
}
