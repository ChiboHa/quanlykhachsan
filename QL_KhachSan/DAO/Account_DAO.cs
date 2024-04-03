using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QL_KhachSan.DAO
{
    internal class Account_DAO
    {
        private static Account_DAO instance;
        private Account_DAO() { }

        internal static Account_DAO Instance
        {
            get
            {
                if (instance == null) instance = new Account_DAO();
                return instance;
            }
            private set => instance = value;
        }

        public Boolean getLogin(String username, String password)
        {
            String sql = "SELECT * FROM Account WHERE UserName = @Username AND PassWord = @Password ";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql, new String[] { username, password });
            return result.Rows.Count > 0;
        }
        // Trong lớp Account_DAO

        public string getDisplayName(string username, string password)
        {
            string query = "SELECT DisplayName FROM Account WHERE Username = @Username AND Password = @Password";

            object[] parameters = { username, password };

            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["DisplayName"].ToString();
            }
            else
            {
                return null; // hoặc ném một ngoại lệ chỉ ra rằng người dùng không tồn tại
            }
        }


        public Boolean checkEmail(String email)
        {
            String sql = "SELECT Email FROM Account WHERE Email = @email";
            DataTable result = DataProvider.Instance.ExecuteQuery(sql, new String[] { email });
            return result.Rows.Count > 0;
        }

        public Boolean updatePassword(String password, String email)
        {
            String sql = "UPDATE Account SET password = @password WHERE email = @email";
            int result = DataProvider.Instance.ExecuteNonQuery(sql, new String[] { password, email });
            return result > 0;
        }

        public void sendEmail(String profileName, String email, long code)
        {
            String sql = "EXEC msdb.dbo.sp_send_dbmail \n" +
                              "@profile_name = '" + profileName + "', \n" +
                              "@recipients = '" + email + "',  \n" +
                              "@body = N'<h3>Xin chào,<br>\n\n" +
                              "Chúng tôi đã nhận được yêu cầu đặt lại mật khẩu của bạn<br>\n " +
                              "Nhập mã đặt lại mật khẩu sau đây:<br>\n" +
                              "<td style=\"font-size:15px;font-family:LucidaGrande,tahoma,verdana,arial,sans-serif;" +
                              "padding:14px 32px 14px 32px;background-color:#f2f2f2;border-left:1px solid #ccc;" +
                              "border-right:1px solid #ccc;border-top:1px solid #ccc;border-bottom:1px solid #ccc;" +
                              "text-align:center;border-radius:7px;display:block;border:1px solid #1877f2;" +
                              "background:#e7f3ff\"><span class=\"m_-6708146349662177886mb_text\" " +
                              "style=\"font-family:Helvetica Neue,Helvetica,Lucida Grande,tahoma,verdana,arial,sans-serif;" +
                              "font-size:16px;line-height:21px;color:#141823\"><span style=\"font-size:17px;font-family:Roboto;" +
                              "font-weight:700;margin-left:0px;margin-right:0px\">" + code + "</span></span></td></h3>',  \n" +
                              "@body_format = 'HTML',  \n" +
                              "@subject = N'" + code + " là mã khôi phục mật khẩu của bạn '  \n";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
