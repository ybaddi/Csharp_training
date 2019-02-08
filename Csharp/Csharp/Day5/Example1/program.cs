
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Csharp.Day5.Example1
{
    class program
    {

        // symetrique :  we need a shared key

         // asymetrique : (key public , key private)

        // RinjndaelManager

            // Microsoft API : Microsoft CAPI. DES => DESCryptoServiceProvider
            // ECDiffieHellmanCng

        static void Main(string[] args)
        {
            // declaration la class qui implement DES
            TripleDESCryptoServiceProvider DESClass = new TripleDESCryptoServiceProvider();
            // keys
            byte[] ikey = DESClass.IV;
            byte[] key = DESClass.Key;
            // string message
            string message = " text en clair";

            // excute the crypt process
             byte[] cryptedTextAsByte = Crypt(message, key, ikey);

            // convert the byte on Text
            Console.WriteLine(Convert.ToBase64String(cryptedTextAsByte));

            // decrypt the message
            Console.WriteLine(decCrypt(cryptedTextAsByte, key, ikey));
            

            Console.ReadLine();


        }

        static byte[] Crypt(string message, byte[] key, byte[] ikey)
        {

            byte[] cryptedTestAsByte = Encoding.Default.GetBytes(message);

            TripleDESCryptoServiceProvider DESClass = new TripleDESCryptoServiceProvider();



            var encryptor = DESClass.CreateEncryptor(key, ikey);
            cryptedTestAsByte = encryptor.TransformFinalBlock(cryptedTestAsByte, 0 , cryptedTestAsByte.Length);
            return cryptedTestAsByte;
            
        }


        static string decCrypt(byte[] cryptedTestAsByte, byte[] key, byte[] ikey)
        {

            //byte[] cryptedTestAsByte = Encoding.Default.GetBytes(message);

            TripleDESCryptoServiceProvider DESClass = new TripleDESCryptoServiceProvider();



            var decryptor = DESClass.CreateDecryptor(key, ikey);
            byte[] cryptedTest = decryptor.TransformFinalBlock(cryptedTestAsByte, 0, cryptedTestAsByte.Length);
            return Encoding.Default.GetString(cryptedTest);

        }
    }
}