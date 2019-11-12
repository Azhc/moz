﻿using System;
using Moz.Bus.Dtos.Auth;
using Moz.Bus.Models.Members;
using Moz.CMS.Models.Members;

namespace Moz.Auth
{
    public interface IAuthService
    {
        
        SimpleMember GetAuthenticatedMember();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        long GetAuthenticatedUserId();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="memberId"></param>
        /// <param name="roleId"></param>
        /// <param name="expDatetime"></param>
        /// <returns>true 成功, false 失败</returns>
        bool AddRoleToMemberId(long memberId, long roleId, DateTime? expDatetime = null);

        
        /// <summary>
        /// 用户名密码登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        LoginWithPasswordResponse LoginWithPassword(LoginWithPasswordRequest request);

        /// <summary>
        /// 三方授权登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        ExternalAuthResponse ExternalAuth(ExternalAuthRequest request);


        void SetAuthCookie(string token);


        void RemoveAuthCookie();

    }
}