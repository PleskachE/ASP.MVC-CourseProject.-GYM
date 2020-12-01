﻿using CourseProject.GYM.Models;

using System;
using System.Linq;
using System.Web.Security;

namespace CourseProject.GYM.Providers
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override string[] GetRolesForUser(string username)
        {
            string[] roles = new string[] { };
            var user = UsersAndRolesRepository.UserService.GetUsers().FirstOrDefault(x => x.Login == username);
            if(user != null)
            {
                roles.Append(UsersAndRolesRepository.RoleService.GetById(user.RoleId).Name);
            }
            return roles;
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            bool outputResult = false;

            var user = UsersAndRolesRepository.UserService.GetUsers().FirstOrDefault(x => x.Login == username);
            if (user != null)
            {
                var role = UsersAndRolesRepository.RoleService.GetById(user.RoleId);
                if(role != null)
                {
                    outputResult = true;
                }
            }

            return outputResult;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}