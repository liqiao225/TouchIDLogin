﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinFingerprint.Interface
{
    public interface ICredentialsService
    {
        string UserName { get; }

        string Password { get; }

        void SaveCredentials(string userName, string password);

        void DeleteCredentials();

        bool DoCredentialsExist();
    }
}
