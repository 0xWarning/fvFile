using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace fvFile.Classes
{
    internal class AuthAPI
    {
        public class UserLoggedInfo
        {
            public static string name { get; set; }
            public static string email { get; set; }
            public static string token { get; set; }
        }

        public class AuthToken
        {
            public static string token { get; set; }
        }

        public class LoginInfo
        {
            public static string email { get; set; }
            public static string password { get; set; }
        }

        public class SignUpInfo
        {
            public static string name { get; set; }
            public static string email { get; set; }
            public static string password { get; set; }
            public static string rwip { get; set; }
            public static string referral { get; set; }
        }

        public bool Login(string email, string password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:1337/api/user/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            try
            {
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        email = email,
                        password = password,
                    });
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong report to developer");
                return false;
            }

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    AuthToken.token = result;
                    UserLoggedInfo.email = email;
                    UserLoggedInfo.token = result;
                    MessageBox.Show(result);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Username or Password");
                return false;
            }
        }

        public bool Register(string name, string email, string password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:1337/api/user/register");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    name = name,
                    email = email,
                    password = password,
                    registedwip = "8.8.8.8",
                    referral = "1"
                });
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    AuthToken.token = result;
                    MessageBox.Show("Succesfully Registered");
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details not filled correctly");
                return false;
            }
        }
    }
}
