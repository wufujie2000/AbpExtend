﻿// Decompiled with JetBrains decompiler
// Type: Abp.AspNetZeroCore.Web.Authentication.External.IExternalAuthManager
// Assembly: Abp.AspNetZeroCore.Web, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null
// MVID: E82D7A41-87A0-49FB-853C-F00596815594
// Assembly location: C:\Users\fuliang\.nuget\packages\abp.aspnetzerocore.web\1.2.2\lib\netcoreapp2.2\Abp.AspNetZeroCore.Web.dll

using System.Threading.Tasks;

namespace Abp.AspNetZeroCore.Web.Authentication.External
{
  public interface IExternalAuthManager
  {
    Task<bool> IsValidUser(string provider, string providerKey, string providerAccessCode);

    Task<ExternalAuthUserInfo> GetUserInfo(
      string provider,
      string accessCode);
  }
}
