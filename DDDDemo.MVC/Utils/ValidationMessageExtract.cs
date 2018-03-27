using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDDemo.Dominio.Tests.Utils
{
    public class ValidationMessageExtract
    {
        private readonly string _validationMessage;

        public ValidationMessageExtract(string validationMessage)
        {
            _validationMessage = validationMessage;
        }

        public string SeparateField()
        {
            if (_validationMessage.ToString().Trim().IndexOf("|") != -1)
            {
                string[] param = _validationMessage.ToString().Trim().Split('|');

                return param[0];
            }

            return "";
        }

        public string SeparateMessage()
        {
            if (_validationMessage.ToString().Trim().IndexOf("|") != -1)
            {
                string[] param = _validationMessage.ToString().Trim().Split('|');

                return param[1];
            }

            return _validationMessage;
        }
    }
}
