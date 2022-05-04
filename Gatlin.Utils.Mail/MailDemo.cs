namespace Gatlin.Utils.Mail
{
#if DEBUG
    class MailDemo
    {
        public static bool MailTest()
        {
            var email = new Email();
            email.mailFrom = "00000@qq.com";
            email.mailPwd = "aaaaaa";
            email.mailSubject = "邮件主题";
            email.mailBody = "邮件内容";
            email.isbodyHtml = true;    //是否是HTML
            email.host = "smtp.qq.com";//如果是QQ邮箱则：smtp.qq.com,依次类推 smtp.126.com
            email.mailToArray = new string[] { "aaaaaa@126.com" };//接收者邮件集合
            //email.mailCcArray = new string[] { "******@qq.com" };//抄送者邮件集合

            return email.Send();
        }
    }
#endif
}
