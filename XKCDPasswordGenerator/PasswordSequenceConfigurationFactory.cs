using KeePassLib.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XKCDPasswordGenerator
{
    class PasswordSequenceConfigurationFactory
    {

        public static PasswordSequence Prepare_Password_Sequence(PasswordSequenceConfiguration psc, CryptoRandomStream crs)
        {
            return new PasswordSequence(psc, crs);
        }
    }
}
