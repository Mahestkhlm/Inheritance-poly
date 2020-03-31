using System;
using System.Collections.Generic;
using System.Text;

namespace ovningg3
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }
    class NumericInputError : UserError
    {

        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field. This fired an error! ";
        }
    }
    class ValidateNumberError : UserError
    {
        //private int v1;
        //private int v2;

       //public ValidateNumberError(int v1, int v2)
        //{
            //this.v1 = v1;
            //this.v2 = v2;
        //}

        public bool ValidateNumber(double weight, double height)
        {
            if (weight > 80 && height <= 20)
            {
                return true;
            }
            return false;
        }
        public override string UEMessage()
        {

            return "You have entered a negative number, Error! ";


        }
    }

    class TextError : UserError
    {

        public override string UEMessage()
        {

            return "You tried to Enter a number in the text field ";
        }
    }

}

