using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareModel.Constant
{
    public class ClientUrlReact
    {
        public static string REDIRECT_URI_REACT_AUTH = "http://localhost:3000/authentication/login-callback";
        public static string REDIRECT_URI_REACT_RENEW = "http://localhost:3000/silent-renew.html";
        public static string REDIRECT_URI_REACT_DEFAULT = "http://localhost:3000";
        public static string POST_LOGOUT_REDIRECT_URI_REACT_AUTH = "http://localhost:3000/authentication/logout-callback";
        public static string POST_LOGOUT_REDIRECT_URI_REACT_RENEW = "http://localhost:3000/unauthorized";
        public static string POST_LOGOUT_REDIRECT_URI_REACT_DEFAULT = "http://localhost:3000";
        public static string ALLOWWED_CORS_ORIGIN = "http://localhost:3000";
    }
}
