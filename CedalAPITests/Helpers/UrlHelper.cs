using System;
using System.Collections.Generic;
using System.Text;

namespace CedalAPITests.Helpers
{
    public static class UrlHelper
    {
        private const string ApiPrefix = "api";
        private const string EventsController = "Events";
        private const string ApplicantsController = "Applicants";
        private const string AdministrativeController = "Administrative";
        private const string UsersController = "Users";

        #region Events
        public static string GetUpcomingEvents()
        {
            return $"{ApiPrefix}/{EventsController}/UpcomingEvents";
        }

        public static string GetPassedEvents()
        {
            return $"{ApiPrefix}/{EventsController}/PassedEvents";
        }

        public static string GetAllEvents()
        {
            return $"{ApiPrefix}/{EventsController}/AllEvents";
        }

        public static string GetNumberOfEvents()
        {
            return $"{ApiPrefix}/{EventsController}/NumberOfEvents";
        }

        public static string CreateEvent()
        {
            return $"{ApiPrefix}/{EventsController}/CreateEvent";
        }

        #endregion

        #region Applicants
        public static string GetListOfApplicants()
        {
            return $"{ApiPrefix}/{ApplicantsController}/ListOfApplicants";
        }

        public static string GetNumberOfApplicants()
        {
            return $"{ApiPrefix}/{ApplicantsController}/NumberOfApplicants";
        }

        public static string CreateApplicants()
        {
            return $"{ApiPrefix}/{ApplicantsController}";
        }

        #endregion

    }
}
