using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace CourseFinalProject_UserLoginSystem
{
    class DatabaseHandler
    {
        // Database Default Query

        protected SqlConnection SqlConnection { get; set; }
        protected SqlCommand SqlCommand { get; set; }
        public string cmdText { get; set; }
        protected static string Key = "abcdefghijklmnopqrstuvwxyz012345";
        protected static string IV = "0123456789abcdef";

        public void Start()
        {
            this.SqlConnection = new SqlConnection("Server=JK-PC;Database=UserLoginSystem;Integrated Security=true;");
            this.SqlCommand = new SqlCommand(cmdText);
            SqlCommand.Connection = this.SqlConnection;
            this.SqlConnection.Open();
        }

        public void Stop()
        {
            this.SqlConnection.Close();
        }

        public string Encryptor(string inputData)
        {
            byte[] inputDataToBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(inputData);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            byte[] encryptedData = crypto.TransformFinalBlock(inputDataToBytes, 0, inputDataToBytes.Length);
            crypto.Dispose();
            return Convert.ToBase64String(encryptedData);
        }

        public string Decryptor(string encryptedData)
        {
            byte[] inputDataToByte = Convert.FromBase64String(encryptedData);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;
            ICryptoTransform crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            byte[] decryptedData = crypto.TransformFinalBlock(inputDataToByte, 0, inputDataToByte.Length);
            crypto.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(decryptedData);
        }



        // Searching Query

        internal bool CheckUserExistsByEmail(string email)
        {
            DatabaseHandler db = new DatabaseHandler();

            try
            {
                db.cmdText = "SELECT Email FROM Users WHERE Email='" + email + "'";
                db.Start();
                SqlDataReader dr = db.SqlCommand.ExecuteReader();

                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }
        }

        internal bool VerifyUser(string email, string password)
        {
            DatabaseHandler db = new DatabaseHandler();
            DataTable dt = new DataTable();

            try
            {
                db.cmdText = "SELECT Email, SecurityPassword FROM Users WHERE Email = '" + email + "'";
                db.Start();
                dt.Load(db.SqlCommand.ExecuteReader());

                string passwordX = db.Decryptor(dt.Rows[0]["SecurityPassword"].ToString().Trim());

                if (passwordX.Equals(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }
        }

        internal DataTable GetUserByEmail(string email)
        {
            DatabaseHandler db = new DatabaseHandler();
            DataTable dt = new DataTable();

            try
            {
                db.cmdText = "SELECT UserID, FirstName, LastName, FullName, Email, ActivationStatus, SecurityQuestion, SecurityAnswer FROM Users WHERE Email = '" + email + "'";
                db.Start();
                dt.Load(db.SqlCommand.ExecuteReader());
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }

            return dt;
        }

        internal DataTable GetUserListForAdmin()
        {
            DatabaseHandler db = new DatabaseHandler();
            DataTable dt = new DataTable();

            try
            {
                db.cmdText = "SELECT UserID, FirstName, LastName, FullName, Email FROM Users ORDER BY UserID";
                db.Start();
                dt.Load(db.SqlCommand.ExecuteReader());
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }

            return dt;
        }

        internal DataTable GetActiveUserListForAdmin()
        {
            DatabaseHandler db = new DatabaseHandler();
            DataTable dt = new DataTable();

            try
            {
                db.cmdText = "SELECT UserID, FirstName, LastName, FullName, Email FROM Users WHERE ActivationStatus = 'Y' ORDER BY UserID";
                db.Start();
                dt.Load(db.SqlCommand.ExecuteReader());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }

            return dt;
        }

        internal DataTable GetDeactiveUserListForAdmin()
        {
            DatabaseHandler db = new DatabaseHandler();
            DataTable dt = new DataTable();

            try
            {
                db.cmdText = "SELECT UserID, FirstName, LastName, FullName, Email FROM Users WHERE ActivationStatus = 'N' ORDER BY UserID";
                db.Start();
                dt.Load(db.SqlCommand.ExecuteReader());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }

            return dt;
        }



        // Changing Query


        internal bool ChangePasswordById(string userId, string password)
        {
            DatabaseHandler db = new DatabaseHandler();
            string PasswordX = db.Encryptor(password);
            bool flag = false;

            try
            {
                db.cmdText = "UPDATE Users SET SecurityPassword = '" + PasswordX + "' WHERE UserID = '" + userId + "'";
                db.Start();
                db.SqlCommand.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }

            return flag;
        }

        internal DataTable ChangeInfoById(DataModel model)
        {
            DatabaseHandler db = new DatabaseHandler();
            DataTable dt = new DataTable();

            try
            {
                db.cmdText = "UPDATE Users SET FirstName = '" + model.FirstName + "', LastName = '" + model.LastName + "', FullName = '" + model.FullName + "', ActivationStatus = '" + model.ActivationStatus + "', SecurityQuestion = '" + model.SecurityQuestion + "', SecurityAnswer = '" + model.SecurityAnswer + "' WHERE UserID = '" + model.UserId + "';"
                    + "SELECT UserID, FirstName, LastName, FullName, Email, ActivationStatus, SecurityQuestion, SecurityAnswer FROM Users WHERE UserID = '" + model.UserId + "'";
                db.Start();
                dt.Load(db.SqlCommand.ExecuteReader());
                return dt;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }
        }



        // Creating Query

        internal bool CreateUser(DataModel model)
        {
            DatabaseHandler db = new DatabaseHandler();
            string passwordX = db.Encryptor(model.Password);
            bool flag = false;

            try
            {
                db.cmdText = "INSERT INTO Users (FirstName, LastName, FullName, Email, SecurityPassword, SecurityQuestion, SecurityAnswer, ActivationStatus)"
                    + " VALUES ('" + model.FirstName + "', '" + model.LastName + "', '" + model.FullName + "', '" + model.Email + "', '" + passwordX + "', '" + model.SecurityQuestion + "', '" + model.SecurityAnswer + "', '" + model.ActivationStatus + "')";
                db.Start();
                db.SqlCommand.ExecuteNonQuery();
                flag = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                db.Stop();
            }

            return flag;
        }

        internal string GenerateSecurityCode(DataModel model)
        {
            string securityCode = string.Empty;

            try
            {
                Random rnd = new Random();
                securityCode = "Q-" + rnd.Next(000000, 999999).ToString();
                SendEmail(model, securityCode);
            }
            catch (Exception ex)
            {

                throw;
            }

            return securityCode;
        }

        protected void SendEmail(DataModel model, string securityCode)
        {
            try
            {
                // Basic requirement for send an email
                string receiverEmail = model.Email;
                string senderEmail = "demo.jeshadkhan@gmail.com";
                string senderPassword = "demo.JK#123";
                string mailSubject = "Security Code - Login System Demo";
                string mailBody = string.Format("<html><body><h1 style='color: #27ae60;' align='center'>Login System</h1><p>Dear <b>{0}</b>,<br />Your security code is: <b>{1}</b><br /><br />Thanks,<br />Login System</p></body></html>", model.FullName, securityCode);
                string smtpServer = "smtp.gmail.com";
                int portNumber = 587;

                // Ready a mail to send
                MailMessage mail = new MailMessage(senderEmail, receiverEmail, mailSubject, mailBody);
                mail.To.Add(receiverEmail);
                mail.IsBodyHtml = true;
                mail.Headers.Add("Notification-To", receiverEmail);
                mail.Priority = MailPriority.High;

                // Sent Email
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = smtpServer;
                smtpClient.Port = portNumber;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
                smtpClient.Send(mail);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
