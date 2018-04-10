using System;

namespace MeltingApp.Resources
{
    public static class ApiRoutes
    {
        /// <summary>
        /// Methods names for the endpoints
        /// </summary>
        public static string ActivateUserMethodName
        {
            get { return ActivateUserMethodName; }
            set { ActivateUserMethodName = "Activate"; }
        }

        public static string RegisterUserMethodName
        {
            get { return RegisterUserMethodName; }
            set { RegisterUserMethodName = "Register"; }
        }


        /// <summary>
        /// Endpoints
        /// </summary>
        public static String ActivateUserPath
        {
            get { return ActivateUserPath; }
            set { ActivateUserPath = "/activate"; }

        }

       

        public static String RegisterUserPath
        {
            get { return RegisterUserPath; }
            set { RegisterUserPath = "/register"; }
        
        }

        

    }
}
