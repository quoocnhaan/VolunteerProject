using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VolunProject.Data.DTO;
using VolunProject.Data.EntityADO.NET;
using System.Windows.Forms;

namespace VolunProject
{
    public class OtherFunction
    {
        public static void autocomplete(TextBox a, List<string> b)
        {
            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            foreach (string s in b)
            {
                allowedTypes.Add(s);
            }
            a.AutoCompleteMode = AutoCompleteMode.Suggest;
            a.AutoCompleteSource = AutoCompleteSource.CustomSource;
            a.AutoCompleteCustomSource = allowedTypes;
        }
        public static string guiMailLayMK(string randomnumber)

        {
            string htmlBody = $@"<h2>Mã xác thực lấy lại mật khẩu</h2>
            <p>Xin chào,</p>
            <p>Cảm ơn bạn đã sử dụng dịch vụ. Dưới đây là mã xác nhận lấy lại mật khẩu:</p>
            <hr/>
            <h3>{randomnumber}</h3>
            <hr/>
            <p>Cảm ơn bạn rất nhiều!</p>";
            return htmlBody;
        }
        public static string templateLayMK(string account, string password)

        {
            string htmlBody = $@"<h2>Thông tin tài khoản</h2>
            <p>Xin chào,</p>
            <p>Cảm ơn bạn đã sử dụng dịch vụ. Dưới đây là thông tin tài khoản của bạn:</p>
            <hr/>
            <h3> Tài khoản: {account}</h3>
            <h3> Mật khẩu: {password}</h3>
            <hr/>
            <p>Cảm ơn bạn rất nhiều!</p>";
            return htmlBody;
        }
        public static void SendEmail(string to, string subject, string body)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("kietvan.31201024409@st.ueh.edu.vn", "0906889483");
            var mailMessage = new MailMessage("kietvan.31201024409@st.ueh.edu.vn", to, subject, body);
            mailMessage.IsBodyHtml = true;
            smtpClient.Send(mailMessage);
        }
        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public static byte[] PathImage2Byte(string path)
            {
                try
                {
                    string imagePath = path;
                    byte[] imageBytes = File.ReadAllBytes(imagePath);


                    return imageBytes;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                return null;
            }
        public static class SessionManager
        {
            private static Dictionary<string, object> sessionValues = new Dictionary<string, object>();

            public static void SetSessionValue(string key, object value)
            {
                if (sessionValues.ContainsKey(key))
                {
                    sessionValues[key] = value;
                }
                else
                {
                    sessionValues.Add(key, value);
                }
            }

            public static T GetSessionValue<T>(string key)
            {
                if (sessionValues.ContainsKey(key) && sessionValues[key] is T)
                {
                    return (T)sessionValues[key];
                }

                return default(T);
            }
            public static void RemoveSession(string key)
            {
                if (sessionValues.ContainsKey(key))
                {
                    sessionValues.Remove(key);
                }
            }

            public static bool ContainsKey(string key)
            {
                return sessionValues.ContainsKey(key);
            }
        }
        public class RewardComparer : IEqualityComparer<RewardDTO>
        {
            public bool Equals(RewardDTO x, RewardDTO y)
            {
                return x.RewardID == y.RewardID;
            }

            public int GetHashCode(RewardDTO obj)
            {
                return obj.RewardID.GetHashCode();
            }
        }

        public class Gender
        {
            public bool genderValue { get; set; }
            public string genderDisplay { get; set; }
        }

    }
}
