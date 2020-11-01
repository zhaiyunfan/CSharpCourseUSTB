using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpCourseUSTB
{
    public partial class Homework6Form1 : Form
    {
        static public string file;
        static public int codeType;    //RSA=1,DES=2
        public Homework6Form1()
        {
            InitializeComponent();
        }

        private void selectFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                file = dialog.FileName;
            }
        }

        //RSA加密代码
        private bool encryptRSA()
        {
            FileStream f;
            try
            {
                f = new FileStream(file, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            }
            catch
            {
                return false;
            }
            Random r = new Random();
            Thread.Sleep(10 * r.Next(3, 8));
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            rsa.FromXmlString("<RSAKeyValue><Modulus>5m9m14XH3oqLJ8bNGw9e4rGpXpcktv9MSkHSVFVMjHbfv+SJ5v0ubqQxa5YjLN4vc49z7SVju8s0X4gZ6AzZTn06jzWOgyPRV54Q4I0DCYadWW4Ze3e+BOtwgVU1Og3qHKn8vygoj40J6U85Z/PTJu3hN1m75Zr195ju7g9v4Hk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
            //导入密钥
            byte[] data = new byte[16];
            ArrayList con = new ArrayList();
            while (f.Read(data, 0, 16) != 0)
            {

                byte[] result = rsa.Encrypt(data, false);
                //Thread.Sleep(10 * r.Next(2, 7));
                con.Add(result);
            }
            //加密
            f.Seek(0, SeekOrigin.Begin);
            foreach (byte[] d in con)
            {
                f.Write(d, 0, d.Length);
            }

            f.Close();
            return true;
        }

        //RSA解密代码
        private bool decryptRSA()
        {
            FileStream f;
            try
            {
                f = new FileStream(file, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            }
            catch
            {
                return false;
            }
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
            try
            {
                rsa.FromXmlString("<RSAKeyValue><Modulus>5m9m14XH3oqLJ8bNGw9e4rGpXpcktv9MSkHSVFVMjHbfv+SJ5v0ubqQxa5YjLN4vc49z7SVju8s0X4gZ6AzZTn06jzWOgyPRV54Q4I0DCYadWW4Ze3e+BOtwgVU1Og3qHKn8vygoj40J6U85Z/PTJu3hN1m75Zr195ju7g9v4Hk=</Modulus><Exponent>AQAB</Exponent><P>/hf2dnK7rNfl3lbqghWcpFdu778hUpIEBixCDL5WiBtpkZdpSw90aERmHJYaW2RGvGRi6zSftLh00KHsPcNUMw==</P><Q>6Cn/jOLrPapDTEp1Fkq+uz++1Do0eeX7HYqi9rY29CqShzCeI7LEYOoSwYuAJ3xA/DuCdQENPSoJ9KFbO4Wsow==</Q><DP>ga1rHIJro8e/yhxjrKYo/nqc5ICQGhrpMNlPkD9n3CjZVPOISkWF7FzUHEzDANeJfkZhcZa21z24aG3rKo5Qnw==</DP><DQ>MNGsCB8rYlMsRZ2ek2pyQwO7h/sZT8y5ilO9wu08Dwnot/7UMiOEQfDWstY3w5XQQHnvC9WFyCfP4h4QBissyw==</DQ><InverseQ>EG02S7SADhH1EVT9DD0Z62Y0uY7gIYvxX/uq+IzKSCwB8M2G7Qv9xgZQaQlLpCaeKbux3Y59hHM+KpamGL19Kg==</InverseQ><D>vmaYHEbPAgOJvaEXQl+t8DQKFT1fudEysTy31LTyXjGu6XiltXXHUuZaa2IPyHgBz0Nd7znwsW/S44iql0Fen1kzKioEL3svANui63O3o5xdDeExVM6zOf1wUUh/oldovPweChyoAdMtUzgvCbJk1sYDJf++Nr0FeNW1RB1XG30=</D></RSAKeyValue>");
                //导入密钥
            }
            catch
            {
                return false;
            }

            byte[] data = new byte[128];
            ArrayList con = new ArrayList();
            while (f.Read(data, 0, 128) != 0)
            {
                byte[] result;
                try
                {
                    result = rsa.Decrypt(data, false);
                }
                catch
                {
                    return false;
                }
                con.Add(result);
            }
            //解密
            f.SetLength(con.Count * 16);
            f.Seek(0, SeekOrigin.Begin);
            foreach (byte[] d in con)
            {
                f.Write(d, 0, d.Length);
            }
            f.Close();
            return true;
        }

        /// 加密文件
        public static void EncryptDES()
        {
            string keyString = "yunfannb";
            var des = GetDesCryptoServiceProvider(keyString);
            //创建加密器
            ICryptoTransform cryptoTransform = des.CreateEncryptor();
            CryptoFileContent(file, file, cryptoTransform);
        }

        /// 解密文件
        public static void DecryptDES()
        {
            string keyString = "yunfannb";
            var des = GetDesCryptoServiceProvider(keyString);
            //创建解密器
            ICryptoTransform cryptoTransform = des.CreateDecryptor();
            CryptoFileContent(file, file, cryptoTransform);
        }

        /// 获取加密服务提供者
        private static DESCryptoServiceProvider GetDesCryptoServiceProvider(string keyStr)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(keyStr);
            //计算指定字节组指定区域哈希值
            SHA1 sha = new SHA1Managed();
            byte[] hash = sha.ComputeHash(keyBytes);
            //加密密钥数组
            byte[] key = new byte[8];
            for (int i = 0; i < 8; i++)
            {
                key[i] = hash[i];
            }
            //DES加密
            DESCryptoServiceProvider des = new DESCryptoServiceProvider { Key = key, IV = key };
            return des;
        }

        /// 加密或解密文件内容
        private static void CryptoFileContent(string filePath, string savePath, ICryptoTransform cryptoTransform)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (CryptoStream cryptoStream =
                    new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write))
                {
                    var inputByteArray = ReadFileAsBytes(filePath);
                    cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
                    cryptoStream.FlushFinalBlock();
                    SaveFile(savePath, memoryStream);
                }
            }
        }

        /// 保存文件
        private static void SaveFile(string savePath, MemoryStream memoryStream)
        {
            using (FileStream fileStream = File.OpenWrite(savePath))
            {
                memoryStream.WriteTo(fileStream);
            }
        }

        /// 读取文件内容为字节
        private static byte[] ReadFileAsBytes(string filePath)
        {
            FileStream fileStream = File.OpenRead(filePath);
            using (BinaryReader binaryReader = new BinaryReader(fileStream))
            {
                byte[] inputByteArray = new byte[fileStream.Length];
                binaryReader.Read(inputByteArray, 0, inputByteArray.Length);
                return inputByteArray;
            }
        }


        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectFile();
            Console.WriteLine(file);
            codeType = (int)MessageBox.Show("请选择加密解密方法，确认选取RSA，取消选取DES", "提示", MessageBoxButtons.OKCancel);
            Console.WriteLine(codeType);
            if (codeType==1)
            {
                if(encryptRSA())
                {
                    MessageBox.Show("加密成功");
                }
                else
                {
                    MessageBox.Show("加密失败");
                }
            }
            else if (codeType==2)
            {
                EncryptDES();
                MessageBox.Show("加密成功");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectFile();
            Console.WriteLine(file);
            codeType = (int)MessageBox.Show("请选择加密解密方法，确认选取RSA，取消选取DES", "提示", MessageBoxButtons.OKCancel);
            Console.WriteLine(codeType);
            if (codeType == 1)
            {
                if (decryptRSA())
                {
                    MessageBox.Show("解密成功");
                }
                else
                {
                    MessageBox.Show("解密失败");
                }
            }
            else if (codeType == 2)
            {
                DecryptDES();
                MessageBox.Show("解密成功");
            }
        }
    }
}
