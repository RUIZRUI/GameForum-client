using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameForum.model
{
    /// <summary>
    /// 用户类
    /// </summary>
    public class User
    {
        // 用户ID
        private string userId = "";
        // 用户ID访问器
        public string UserId { get { return userId; } set { userId = value; } }

        // 用户名
        private string userName = "";
        // 用户名访问器
        public string UserName { get { return userName; } set { userName = value; } }

        // 邮箱
        private string userEmail = "";
        // 邮箱访问器
        public string UserEmail { get { return userEmail; } set { userEmail = value; } }

        // 手机号
        private string userPhone = "";
        // 手机号访问器
        public string UserPhone { get { return userPhone; } set { userPhone = value; } }

        // 性别
        private string userSex = "";
        // 性别访问器
        public string UserSex { get { return userSex; } set { userSex = value; } }

        // 生日
        private string userBirthday = "";
        // 生日访问器
        public string UserBirthday { get { return userBirthday; } set { userBirthday = value; } }

        // 加入时间
        private string userJoinTime = "";
        // 加入时间访问器
        public string UserJoinTime { get { return userJoinTime; } set { userJoinTime = value; } }

        // 关注数
        private int followNum = 0;
        // 关注数访问器
        public int FollowNum { get { return followNum; } set { followNum = value; } }

        // 粉丝数
        private int fanNum = 0;
        // 粉丝数访问器
        public int FanNum { get { return fanNum; } set { fanNum = value; } }

        // 头像链接
        private string userAvatarUrl = "";
        // 头像链接访问器
        public string UserAvatarUrl { get { return userAvatarUrl; } set { userAvatarUrl = value; } }

        public override string ToString()
        {
            return "LoginInfo { userId: " + UserId + ", userName: " + UserName + ", userEmail: " + UserEmail + ", userPhone: " + UserPhone + ", userSex: " + UserSex +
                    ", userBirthday: " + UserBirthday + ", userJoinTime: " + UserJoinTime + ", followNum: " + FollowNum + ", fanNum: " + FanNum +
                    ", userAvatarUrl: " + UserAvatarUrl + "}";
        }
    }
}
