using HuongDuongVillage.DAO;
using HuongDuongVillage.DTO;
using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace HuongDuongVillage
{
    /// <summary>
    /// Interaction logic for ChangePassword.xaml
    /// </summary>
    public partial class ChangePassword : Window
    {
        private string function;
        private int idStaff;
        private string randomcode;
        public static string emailTo;

        public ChangePassword(string _function, int _idStaff = -1)
        {
            InitializeComponent();
            try
            {
                idStaff = _idStaff;
                function = _function;

                if (function != "Reset")
                {
                    grdEmailContainer.Visibility = Visibility.Collapsed;
                    grdVerifyCode.Visibility = Visibility.Collapsed;
                }
                else
                    btnConfirm.Content = "Send";
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #region Event

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (function)
                {
                    case "Reset":
                        if (btnConfirm.Content == "Send")
                            SendMail();
                        else
                            ChangeOldPassword();
                        break;

                    case "Change":
                        ChangeOldPassword();
                        break;
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        #endregion Event

        #region Method
        private void SendMail()
        {
            try
            {
                emailTo = txbEmail.Text.Replace("'", "''");
                idStaff = StaffDAO.Instance.CheckEmailExist(emailTo);
                if (idStaff != -1)
                {
                    string from, pass, messageBody;
                    Random random = new Random();
                    randomcode = (random.Next(100000, 999999)).ToString();
                    MailMessage message = new MailMessage();
                    from = "ooad.hdv.team1@gmail.com";
                    pass = "A12345678*";
                    messageBody =
                        "<body style=\"background-color:#fff;margin:0;padding:0;-webkit-text-size-adjust:none;text-size-adjust:none\"> <table class=\"nl-container\" style=\"background-color: #ffffff; height: 330px; width: 100%;\" role=\"presentation\" border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tbody> <tr style=\"height: 330px;\"> <td style=\"height: 330px;\"> " +
                        "<table class=\"row row-1\" style=\"mso-table-lspace: 0; mso-table-rspace: 0; background-color: #f5f5f5;\" role=\"presentation\" border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\"> <tbody> <tr> <td> <table class=\"row-content stack\" style=\"mso-table-lspace: 0; mso-table-rspace: 0; background-color: #fff; color: #000; width: 500px;\" role=\"presentation\" border=\"0\" width=\"500\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\"> <tbody> <tr> <td class=\"column\" style=\"mso-table-lspace: 0; mso-table-rspace: 0; font-weight: 400; text-align: left; vertical-align: top; padding-top: 0; padding-bottom: 5px; border: 0;\" width=\"100%\"> <table class=\"heading_block\" style=\"height: 78px; width: 100%;\" role=\"presentation\" border=\"0\" width=\"498\" cellspacing=\"0\" cellpadding=\"0\"> <tbody> <tr> <td style=\"text-align: center; width: 100%;\"> <h1 style=\"margin: 0; color: #393d47; direction: ltr; font-family: Tahoma,Verdana,Segoe,sans-serif; font-size: 25px; font-weight: 400; letter-spacing: normal; line-height: 120%; text-align: center; margin-top: 0; margin-bottom: 0;\"><strong>Forgot your password?</strong></h1> </td> </tr> </tbody> </table> <table class=\"text_block\" style=\"mso-table-lspace: 0; mso-table-rspace: 0; word-break: break-word;\" role=\"presentation\" border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"10\"> <tbody> <tr> <td> <div style=\"font-family: Tahoma,Verdana,sans-serif;\"> <div style=\"font-size: 12px; font-family: Tahoma,Verdana,Segoe,sans-serif; mso-line-height-alt: 18px; color: #393d47; line-height: 1.5;\"> <p style=\"margin: 0; font-size: 14px; text-align: center; mso-line-height-alt: 21px;\"><span style=\"font-size: 14px;\">Not to worry, we got you! This is your reset code.</span></p> <p style=\"margin: 0; font-size: 14px; text-align: center; mso-line-height-alt: 21px;\"><span style=\"font-size: 14px;\">Let&rsquo;s get you a new password.</span></p> </div> </div> </td> </tr> </tbody> </table> <table class=\"button_block\" style=\"mso-table-lspace: 0; mso-table-rspace: 0;\" role=\"presentation\" border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"15\"> <tbody> <tr> <td> <div align=\"center\"> <center style=\"color: #393d47; font-family: Tahoma, Verdana, sans-serif; font-size: 18px;\"><div style=\"text-decoration: none; display: inline-block; color: #393d47; background-color: #ffc727; border-radius: 20px; width: auto; padding-top: 10px; padding-bottom: 10px; font-family: Tahoma, Verdana, Segoe, sans-serif; text-align: center; mso-border-alt: none; word-break: keep-all; border: 1px solid #FFC727;\" href=\"#\" target=\"_blank\"> <span style=\"padding-left: 50px; padding-right: 50px; font-size: 18px; display: inline-block; letter-spacing: normal;\"> <span style=\"font-size: 16px; line-height: 2; word-break: break-word; mso-line-height-alt: 32px;\"> <span style=\"font-size: 18px; line-height: 36px;\"> " +
                        "<strong>" + randomcode + "</strong>" +
                        "</span></span></span></div></center> </div> </td> </tr> </tbody> </table> <table class=\"text_block\" style=\"word-break: break-word; height: 19px; width: 100%;\" role=\"presentation\" border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\"> <tbody> <tr style=\"height: 19px;\"> <td style=\"padding: 10px 10px 5px; height: 19px;\"> <div style=\"font-family: Tahoma,Verdana,sans-serif;\"> <div style=\"font-size: 12px; font-family: Tahoma,Verdana,Segoe,sans-serif; text-align: center; mso-line-height-alt: 18px; color: #393d47; line-height: 1.5;\"> <p style=\"margin: 0; mso-line-height-alt: 19.5px;\"><span style=\"font-size: 13px;\">If you didn&rsquo;t request to change your password, simply ignore this email.</span></p> </div> </div> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> " +
                        "<table class=\"row row-2\" style=\"mso-table-lspace: 0; mso-table-rspace: 0; background-color: #fff;\" role=\"presentation\" border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\"> <tbody> <tr> <td> <table class=\"row-content stack\" style=\"color: #000000; width: 500px; height: 25px;\" role=\"presentation\" border=\"0\" width=\"500\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\"> <tbody> <tr style=\"height: 25px;\"> <td class=\"column\" style=\"font-weight: 400; text-align: left; vertical-align: top; padding-top: 5px; padding-bottom: 5px; border: 0px; height: 25px; width: 498px;\"> <table class=\"text_block\" style=\"height: 10px; word-break: break-word; width: 100%;\" role=\"presentation\" border=\"0\" width=\"100%\" cellspacing=\"0\" cellpadding=\"10\"> <tbody> <tr style=\"height: 10px;\"> <td style=\"height: 10px; width: 100%;\"> <div style=\"font-family: Tahoma,Verdana,sans-serif;\"> <div style=\"font-size: 12px; font-family: Tahoma,Verdana,Segoe,sans-serif; mso-line-height-alt: 14.399999999999999px; color: silver; line-height: 1.2;\"> <p style=\"margin: 0; text-align: center;\"><span style=\"background-color: transparent;\">35A Văn Cao, Đằng Giang, Ng&ocirc; Quyền, Hải Ph&ograve;ng &nbsp;/ &nbsp;0225 3892 022</span><span style=\"color: #c0c0c0;\">&nbsp;</span></p> </div> </div> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </body>";
                    message.To.Add(emailTo);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Verification code change password";
                    message.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        CustomAlertBox.Show("Code send success!. Please check your email. Make sure check in spam/trash.");
                        btnConfirm.Content = "Confirm";
                    }
                    catch (Exception ex)
                    {
                        CustomAlertBox.Show(ex.Message);
                    }
                }
                else
                {
                    CustomAlertBox.Show("Wrong Email. Try Again!!!!");
                }
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private void ChangeOldPassword()
        {
            try
            {
                if (function == "Reset")
                    if (!IsCorrectCode())
                        return;

                string password = txbPasswordEmployee.Password;
                string cfpassword = txbConfirmPassword.Password;
                AccountDTO acc = AccountDAO.Instance.GetAccountByIdUser(idStaff);

                if (password == cfpassword)
                {
                    if (AccountDAO.Instance.ChangePassword(acc.UserName, password))
                    {
                        CustomAlertBox.Show("Successfully");

                        this.Close();
                    }
                    else
                        CustomAlertBox.Show("Failed");
                }
                else
                    CustomAlertBox.Show("Password didn't match!!");
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        #endregion Method

        #region Validate

        private void OnlyNumber(object sender, TextCompositionEventArgs e)
        {
            try
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
            }
        }

        private bool IsCorrectCode()
        {
            try
            {
                if (txbVerifyCode.Text != randomcode)
                {
                    CustomAlertBox.Show("Error", "Your reset code is incorrect. Please check your email again.", CustomAlertBox.MessageBoxType.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                CustomAlertBox.Show(ex.Message);
                return false;
            }
        }
        #endregion Validate
    }
}