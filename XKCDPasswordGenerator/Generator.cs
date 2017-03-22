using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KeePassLib;
using KeePassLib.Cryptography;
using KeePassLib.Cryptography.PasswordGenerator;
using KeePassLib.Security;

namespace XKCDPasswordGenerator
{
    public class Generator : CustomPwGenerator
    {
        private static readonly PwUuid UUID =
            new PwUuid(new byte[] {
                        0x53, 0x81, 0x36, 0x0E, 0xA7, 0xFC, 0x48, 0x36,
                        0x9E, 0x9F, 0xA4, 0x4F, 0x1A, 0xF0, 0x58, 0x37
            });
        public override PwUuid Uuid
        {
            get
            {
                return UUID;
            }
        }

        public override string Name
        {
            get
            {
                return "XKCDPasswordGenerator";
            }
        }

        public override ProtectedString Generate(PwProfile prf, CryptoRandomStream crsRandomSource)
        {
            string targetSequence = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                targetSequence += "Hello";
            }
            //foreach (SequenceItem sequenceItem in globalConfiguration.Sequence)
            //{
            //targetSequence += new ItemGenerator.ItemGenerator(globalConfiguration)
            //                .Generate(sequenceItem, cryptoRandom);
            //}
            return new ProtectedString(true, targetSequence);
            //throw new NotImplementedException();
        }
    }
}
