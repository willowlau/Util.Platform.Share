﻿namespace Util.Platform.Share.Identity.Enums; 

/// <summary>
/// 登录状态
/// </summary>
public enum SignInState {
    /// <summary>
    /// 登录成功
    /// </summary>
    Succeeded,
    /// <summary>
    /// 失败
    /// </summary>
    Failed,
    /// <summary>
    /// 需要双因素认证
    /// </summary>
    TwoFactor
}