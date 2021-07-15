﻿using System;
using System.Collections.Generic;
using System.Text;
using MyStuff.Models;

using System.Threading.Tasks;

namespace MyStuff.ViewModels
{
    public class UserViewModel : BaseViewModel
    {

        public User MyUser { get; set; }

        public UserViewModel()
        {
            MyUser = new User();

            //TODO: Implementar los Command correspondientes. 
        }

        //Ahora implementamos una función para ser consumida desde la vista 

        public async Task<bool> GuardarUsuario(string Pusername, string Pname, string PuserPassword,
                                               string Pphone, string PbackupEmail)
        {
            if (IsBusy) return false;

            IsBusy = true;

            try
            {
                MyUser.Username = Pusername;
                MyUser.Name = Pname;
                MyUser.UserPassword = PuserPassword;
                MyUser.Phone = Pphone;
                MyUser.BackupEmail = PbackupEmail;

                bool R = await MyUser.GuardarUsuario();

                return R;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                IsBusy = false;
            }
        
        }

    }
}
